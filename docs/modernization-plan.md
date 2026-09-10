# JAWS Application Modernization Plan

> **Status:** Research / planning only — no code changes have been made.
> **Purpose:** Durable record of the modernization assessment and strategy so this
> effort can be resumed in any future session (or by another developer) without
> re-discovering the codebase.

---

## 1. Goal

Rewrite the legacy JAWS court case-management application onto a **current .NET
framework** with the following target characteristics:

- **UI:** ASP.NET Core **MVC** (replacing ASP.NET WebForms)
- **Language:** **C#** (migrating away from VB.NET)
- **Data layer:** **EF Core**, using a **database-first (reverse-engineered) model**
  against the existing **SQL Server** database
- **Approach:** Stand up a **new modern .NET project** alongside the legacy app,
  reference the legacy code, and port logic incrementally. Legacy projects remain
  untouched as reference until cutover.

---

## 2. Current State (assessment findings)

### 2.1 Solution structure

Solution: `Main/JAWSWebApp/JAWSWebApp.sln`

| Project | Lang | Type | Framework | Notes |
|---|---|---|---|---|
| `JAWSWebApp` | VB | **ASP.NET WebForms** | .NET 4.8 | 50+ `.aspx` pages (BenchView, Calendar, Admin, AsyncOps, etc.) |
| `JawsApp.Service.Web` | VB | **WCF RIA / Domain Services** + EF5 + raw ADO.NET | .NET 4.8 | Service layer mixing three data-access styles |
| `MurdockData` | VB | **Typed DataSet library** (~380 files) | **.NET 3.5** | TableAdapters wrapping SQL Server stored procedures/queries |
| `PdfViewer` | C# | Web control library | .NET 4.8 | Already C#; easiest to carry forward |

### 2.2 Data access — three coexisting styles

All ultimately hit **SQL Server stored procedures**:

1. **Typed DataSets / TableAdapters** — `MurdockData` (~380 generated files). The
   largest body of data logic. Each `Orders_*`, `Case_*`, `FamilyLawJudge*`,
   `Calendar_*` wraps a stored procedure or query.
2. **Raw ADO.NET** — `JawsApp.Service.Web/Entities/Dac.vb`
   (`SqlConnection`/`SqlCommand`/`SqlDataAdapter` calling stored procs; connection
   from `My.MySettings.Default.JawsAppEntities`).
3. **Entity Framework 5 + WCF RIA Domain Services** — e.g. `tblAnnotationService`,
   `tbl_case_fileService` for a handful of tables (annotations, case files).

### 2.3 UI

- Confirmed **WebForms**: `Global.asax` + `.aspx` / `.aspx.designer.vb` / `.aspx.vb`
  triads. No `Controllers/`, `Views/`, or `RouteConfig`.
- Moving to MVC is a genuine **UI rewrite**, not an in-place upgrade. ASP.NET
  WebForms has no equivalent on modern .NET.

### 2.4 Notable dependencies

| Dependency | Status / concern |
|---|---|
| `System.Data.OracleClient` | **Dead** — SQL Server only. Remove. |
| `IBM.Data.Informix` | **Dead** — SQL Server only. Remove. |
| WCF RIA / Domain Services (`System.ServiceModel.DomainServices.*`) | Dead-end tech; **no modern .NET equivalent** → replace with ASP.NET Core Web API. |
| DevExpress v14.2 (2014) — RichEdit, HtmlEditor, SpellChecker, ASPxSpellChecker | Commercial, **WebForms-only**. Needs modern editor replacement + new licenses. |
| Microsoft ReportViewer (WebForms) | **No supported modern .NET version** → replace reporting engine. |
| AjaxControlToolkit, NetSpell | WebForms-era. |
| Newtonsoft.Json 4.5 | Ancient → move to System.Text.Json (or modern Newtonsoft). |
| iTextSharp 5.5.9 | Last MPL version before AGPL iText7 — licensing decision needed. |
| PDFsharp 1.32, Aspose.Pdf 11 | Version/upgrade decisions needed. |
| BitMiracle.LibTiff.NET | Has modern .NET versions; review. |

---

## 3. Key Decisions & Clarifications

- **Database is SQL Server** (confirmed). Oracle/Informix references are dead code.
- **No `.edmx` exists today.** The current EF5 usage is DbContext-based, not
  Database-First EDMX.
- **EDMX is not supported on EF Core / modern .NET.** EDMX (designer + ObjectContext)
  only works with **EF6 on .NET Framework**. Since the goal is modern .NET, the
  chosen approach is **EF Core reverse-engineering (scaffolding)** — the modern
  equivalent of "database-first": generate entity classes + `DbContext` directly
  from the existing SQL Server schema. No `.edmx` file.
  - *Open item:* If EDMX/Database-First is later deemed a hard requirement, that
    pins the data layer to EF6/.NET Framework and reshapes the plan.

### 3.1 Database schema decision

- **Keep the existing schema as-is for the rewrite.** Do **not** migrate to a new
  schema during the modernization. Reasons:
  - The SQL Server DB is likely **shared/authoritative** — other systems, reports
    (SSRS), integrations, or jobs may depend on it, outside this codebase's
    visibility.
  - Combining a schema migration with an app rewrite **compounds risk** — change
    one variable at a time so failures are diagnosable.
  - EF Core scaffolding reverse-engineers from the existing schema anyway.
- **Schema improvements are a separate, later phase** (only if warranted, e.g.
  missing FKs/relationships, denormalization pain, inconsistent naming) — done
  deliberately *after* the app is stable on modern .NET.

### 3.2 Stored procedures decision — triage, don't keep-all or replace-all

Concern raised: many stored procedures do very little (trivial CRUD) and add
maintenance burden; can LINQ/lambda replicate them? **Answer: triage each proc
into one of four buckets** rather than an all-or-nothing choice.

| Bucket | Description | Action |
|---|---|---|
| 🟢 **A — Trivial CRUD** | `SELECT ... WHERE id=@id`, basic insert/update/delete | **Replace with EF Core LINQ/lambda.** Type-safe, refactorable, one less artifact to sync. This is the maintainability win. Likely a large share of the ~380 `MurdockData` DataSets. |
| 🟡 **B — Query logic** | Multi-join, filtering, aggregation | **Convert to LINQ opportunistically**, unless SQL translates poorly (window functions, recursive CTEs, query hints). |
| 🔴 **C — Complex business logic** | Heavy set-based logic, multi-table transactions, perf-tuned SQL | **Keep as procs, call via `FromSqlRaw`.** Rewriting is high-risk and often worse for perf. |
| ⚠️ **D — Used by other systems** | Called from SSRS, integrations, jobs | **Must keep** even if unused by this app. |

Prerequisite: a read-only **inventory that categorizes each proc/DataSet by
complexity and external usage** to produce a concrete convert-vs-keep list
(see §7).

---

## 4. Data Layer Strategy (EF Core, database-first via scaffolding)

1. Create a **new EF Core class library** (C#, modern .NET).
2. **Scaffold** entities + `DbContext` from the **existing** SQL Server schema
   (`dotnet ef dbcontext scaffold` / reverse engineering). Schema unchanged.
3. **Triage stored procedures (per §3.2):** replace trivial-CRUD procs with EF Core
   LINQ/lambda; keep complex/shared procs and call them via `FromSqlRaw` /
   `SqlQuery` / `ExecuteSqlRaw`. Net effect: eliminate proc bloat while preserving
   valuable/tuned/shared SQL.
4. **Consolidate** the three data-access styles (`MurdockData` DataSets, `Dac.vb`,
   EF5) into the single EF Core library, retiring them incrementally.
5. Move connection strings from `web.config` / `My.Settings` (`JawsAppEntities`) to
   **`appsettings.json`** + a **DI-registered `DbContext`** in `Program.cs`.
6. Swap **`System.Data.SqlClient` → `Microsoft.Data.SqlClient`** (note the
   default-encryption behavior change).

---

## 5. Migration Roadmap (phased)

- **Phase 0 — Assessment (current).** Catalog pages, services, reports, DataSets,
  and dependency usage. Identify live vs. orphaned code.
- **Phase 1 — Isolate the reusable core.** Stand up the new EF Core data project;
  scaffold from the DB; wrap stored procedures.
- **Phase 2 — Rebuild services.** Replace WCF RIA / Domain Services with an
  ASP.NET Core Web API.
- **Phase 3 — Rebuild the UI.** ASP.NET Core MVC in C#, page-by-page. Largest
  effort; dominated by DevExpress + ReportViewer replacements.
- **Phase 4 — Cutover & decommission.** Retire the legacy projects.

### Effort drivers (ranked)

1. 🔴 ~380 typed DataSets in `MurdockData` — re-express/wrap in EF Core.
2. 🔴 50+ WebForms pages → MVC views/controllers (full UI rewrite).
3. 🔴 DevExpress RichEdit/HtmlEditor/SpellChecker (order-drafting UI) — modern
   editor replacement + licensing.
4. 🟡 ReportViewer reports — replace reporting engine.
5. 🟡 WCF RIA services → ASP.NET Core Web API.
6. 🟢 VB → C# conversion — mechanical but voluminous.

### 5.1 Conversion order (grounded in the dependency graph)

Project dependency graph (consumer → dependencies):

```
JAWSWebApp (WebForms UI)   ← top; references all three below
   ├── MurdockData          (typed DataSets)
   ├── JawsApp.Service.Web   (WCF RIA + EF5 + raw ADO.NET)
   └── PdfViewer             (C# control library)
```

Build order (leaf → root): PdfViewer → JawsApp.Service.Web → MurdockData → JAWSWebApp.
The UI sits at the top; the data/support projects are the leaves.

**Because the strategy is build-new-alongside-old (rewrite, not in-place upgrade),
convert bottom-up (foundation first):**

| Order | Work | Notes |
|---|---|---|
| **1** 🟢 | **New EF Core data library** | Replaces `MurdockData` + `Dac.vb` + EF5 (one concern, three styles). Highest effort/risk — prove the pattern early. Testable in isolation against the DB. |
| **2** 🟡 | **ASP.NET Core Web API** | Replaces WCF RIA / Domain Services; consumes the new data library. |
| **3** 🟢 | **`PdfViewer` → modern .NET** | Already C# and a non-blocking leaf. Flexible timing — a low-risk quick win convertible early or alongside the UI. |
| **4** 🔴 | **ASP.NET Core MVC UI** | Rebuild 50+ WebForms pages in C#; largest rewrite; dominated by DevExpress/ReportViewer replacements. Depends on everything below. |

**Answer to "convert support projects first?"** — Yes. Support/data projects go
first, UI last (true under both rewrite and in-place mental models). Nuance:
`MurdockData` is **replaced**, not converted in place; `PdfViewer` is a flexible
quick win rather than a strict prerequisite.

---

## 6. New-Project Strategy (reference old, build new)

- Create the new modern .NET solution/project **inside this same repo/workspace**
  (e.g., a `Modernized/` or `src-net9/` folder next to `Main/`) so both legacy and
  new code are visible in one session for live porting and verification.
- Keep legacy projects untouched as reference until cutover.
- This document (`docs/modernization-plan.md`) is the durable memory that lets the
  effort resume in any future session.

---

## 7. Open Items / Follow-up Research (read-only)

- [ ] **Stored-procedure / DataSet inventory + categorization** — for each proc/
      DataSet, capture: (a) is it actually referenced by the app vs. orphaned,
      (b) which triage bucket it falls in (A trivial CRUD / B query logic /
      C complex / D external), (c) whether it's called by other systems. Produces
      the concrete convert-vs-keep list driving §3.2 and §4.
- [ ] Inventory **DevExpress + ReportViewer** usage across the `.aspx` pages — to
      size the UI-rewrite hotspots.
- [ ] Confirm target modern .NET version (e.g., .NET 8 LTS vs. .NET 9).
- [ ] Decide PDF library strategy (iText7 vs. Aspose vs. PDFsharp modern).
- [ ] Resolve EDMX vs. EF Core scaffolding decision (see §3).

### Resolved decisions

- ✅ **Target framework:** **.NET 10 (LTS)** — newest LTS, longest support runway
  for a long-lived court system; SDK verified installed (10.0.203).
- ✅ **New-project layout (Option B):** modernized apps mirror the legacy
  `Main`/`Attorney` split as top-level siblings. **`Internal`** replaces "Main"
  (internal court-staff/judicial app); the new attorney app name is TBD (cannot
  reuse the legacy `Attorney` folder name). `Jaws.Data` is a shared top-level
  library. Solution: `Jaws.slnx` at the repo root.
- ✅ **Database schema:** keep as-is for the rewrite; schema improvements are a
  separate later phase (see §3.1).
- ✅ **Stored procedures:** triage into four buckets — replace trivial CRUD with
  LINQ, keep complex/shared procs via `FromSqlRaw` (see §3.2).
- ✅ **Conversion order:** bottom-up — data → services → PdfViewer → UI (see §5.1).

### Implementation progress

- ✅ **Step 1 (done):** Created `Jaws.Data` (.NET 10 class library) + `Jaws.slnx`
  solution at repo root. Added EF Core packages (SqlServer, Design, Tools,
  v10.0.11). Build verified. Legacy projects untouched.
- ✅ **Step 2 (done):** Scaffolded the full `JAWSMain` model into `Jaws.Data` via
  `dotnet ef dbcontext scaffold`. Result: **464 entity classes** in `Entities/` +
  `JawsDbContext` in `Context/`. Build: 0 errors, 0 warnings. Used
  `--no-onconfiguring` so **no connection string/credential is baked into source**.
  - ⚠️ **Cert/encryption note:** the SQL server's certificate is not chain-trusted,
    so scaffolding required `TrustServerCertificate=True` (confirms the
    `Microsoft.Data.SqlClient` default-encryption behavior change from §4). For the
    real app: install a trusted cert on the server (preferred) or set
    `Encrypt=True;TrustServerCertificate=True` in config. Connection string goes in
    user secrets / env vars, never committed. **Recommend rotating the shared DB
    password** (it was shared in chat).
- ✅ **Step 3 (done):** Created `Jaws.ConnectivityTest` console app to smoke-test
  the scaffolded model. Reads connection string from **user secrets**
  (`ConnectionStrings:JawsDb`, incl. `TrustServerCertificate=True`) — not committed.
  Result: **connected successfully** to `JAWSMain`; a real LINQ query
  (`TblCase.CountAsync()`) returned **315,106 rows**, confirming the DbContext,
  entity mapping, and query pipeline all work end-to-end.
- **Step 4 (in progress):** Generated stored-procedure inventory via `Jaws.ProcInventory` (reads `sys.procedures` + `sys.sql_modules`). Found **2,200 procedures**. Heuristic triage: **A=481** (trivial CRUD), **B=1,371** (query logic), **C=348** (complex). Report: `docs/stored-procedure-inventory.md`. Caveats: heuristic only; Bucket B is a large review set; Bucket D (external usage) not DB-detectable; app-usage cross-reference pending.
- **Step 4b (done):** Cross-referenced all 2,200 procs against BOTH legacy apps
  (`Main` + `Attorney`, read-only). Result: **1,487 used by either app** (320 both,
  1,159 Main-only, 8 Attorney-only); **713 candidate orphans**. Used by bucket:
  A=320, B=1,011, C=156. Report: `docs/stored-procedure-xref.md`.
- **Data-access policy (decided):** **LINQ-first, build-as-needed.** As each feature
  is rebuilt, implement only the queries it requires:
  - Bucket A (trivial CRUD) and most of Bucket B -> **EF Core LINQ** (no proc).
  - Bucket C (~156 complex: cursors/tran/dynamic/perf-tuned) -> **keep via
    `FromSqlRaw`** only when a feature needs it.
  - **Delete NO procs from the database yet.** "App stops calling a proc" is
    decoupled from "proc is removed." Retire a proc only after confirming no
    external consumer (Bucket D: SSRS, SQL Agent jobs, integrations) - which is not
    detectable from source and needs a DBA-side check.
- **Step 5 (done):** Built the first LINQ-first data slice as the reusable pattern:
  `ICaseRepository` + `CaseRepository` (EF Core LINQ, `AsNoTracking`) +
  `AddJawsData()` DI extension. Exercised via DI against JAWSMain: `CountAsync`
  (315,753), `SearchByCaseNumberAsync`, `GetByCaseNumberAsync` all returned correct
  data. No stored procedures used. Build 0/0. This is the template for all future
  feature data access (interface -> EF Core LINQ -> DI; `FromSqlRaw` only for the
  ~156 complex procs when a feature needs them).
- **Step 6 (done):** Stood up `Internal/Jaws.Internal.Web` (ASP.NET Core MVC, .NET
  10) mirroring the legacy `Main`/`Attorney` split (Option B; `Internal` replaces
  "Main"). Referenced `Jaws.Data`, wired `AddJawsData()` in `Program.cs`, connection
  string in user secrets. Verified end-to-end: app runs and a temp `/health/db`
  endpoint returned `{status:ok, caseCount:315753}` via `ICaseRepository` -> EF Core
  -> JAWSMain. Build 0/0.
  - Note: startup logs show benign EF warnings for `Lku*` tables with `tinyint`
    identity PKs (only relevant for future INSERTs; reads are unaffected). Address
    when building write operations.
  - `/health/db` is a temporary connectivity probe; remove once real screens exist.
- **UI architecture (DECIDED - supersedes earlier MVC note):** **API-first.**
  Backend = **ASP.NET Core Web API** (suggest a dedicated `Jaws.Api` project);
  frontend = **separate Vue/Nuxt client app(s)** for Internal and (later) Attorney.
  Rationale: Main + Attorney share the same functionality -> one API, multiple
  clients (no duplicated server logic); and the **organization already builds in
  Vue/Nuxt**, so this maximizes maintainability, support, and staffing consistency.
  Both stacks (ASP.NET Core Web API, Vue 3/Nuxt 3) are mature and well-supported.
  - Impact: the MVC `Internal/Jaws.Internal.Web` project becomes redundant for UI
    and will likely be retired/repurposed toward the Web API. `Jaws.Data` +
    `AddJawsData()` are unchanged (they sit behind the API).
  - Auth: LDAP login authenticates at the API and issues a cookie/JWT the Vue
    clients use.
  - Tradeoff (accepted): two deployables + two build pipelines - already standard
    practice in the org.
- **Authentication requirement (must-have, not yet built):** the app requires
  **login via LDAP** before DB access, mirroring the legacy apps (which used
  `System.DirectoryServices` / `.AccountManagement` = LDAP/Active Directory).
  Modern plan: ASP.NET Core authentication/authorization middleware
  (`[Authorize]`, policies, cookie/session) with LDAP via
  `System.DirectoryServices.Protocols` (cross-platform) or Negotiate/Windows auth
  if AD. Data layer stays auth-agnostic (`AddJawsData()` unaffected). Add an auth
  step around Step 7/8, before exposing real protected screens, to avoid retrofit.
- **Step 7 (done):** Adopted API-first. Retired MVC `Jaws.Internal.Web` (Option A);
  created `Jaws.Api` (ASP.NET Core Web API, .NET 10) referencing `Jaws.Data`,
  wired `AddJawsData()` + dev CORS. Added `CasesController` (`/api/cases/count`,
  `/search`, `/{id}`) + `CaseDto`. Verified end-to-end against JAWSMain
  (count=316,501; parameterized LIKE search returns correct rows; CORS header
  confirmed for the Vue origin). Added a minimal throwaway Vue client
  (`clients/internal-vue`, CDN, no build) that searches cases via the API. Build 0/0.
  - Security: removed OpenAPI feature - the template''s transitive
    `Microsoft.OpenApi 2.0.0` had a high-severity vuln, and the 3.x fix breaks the
    .NET 10 source generator. OpenAPI is dev-time only; re-add secure Swagger later.
  - Endpoints are currently UNAUTHENTICATED - LDAP auth is the next major step
    before exposing real protected screens.
- **Step 8 (done):** Added LDAP authentication + JWT to `Jaws.Api`, faithfully
  porting the legacy flow from `Main/JAWSWebApp/Login.aspx.vb` (bind-based auth
  against `LDAP://aocpdc1.jud6aoc.org`, domain `COURT13\`, dev-bypass user
  `crtx00073`). Components: `LdapAuthenticator` (System.DirectoryServices.Protocols
  bind), `JwtTokenService`, `AuthController` (`POST /api/auth/login`, `GET
  /api/auth/me`); `CasesController` now `[Authorize]`. Verified end-to-end via
  dev-bypass: 401 without token, login issues JWT, token unlocks protected
  endpoints, bad creds -> 401. Build 0/0. Secrets (JWT key, bypass user) in user
  secrets; LDAP config in appsettings.json.
  - Chose **JWT Bearer** (standard for SPA->API). Switchable to HttpOnly cookies.
  - LDAP server is on the court network / unreachable from dev - **real LDAP bind
    must be tested on-network**; dev-bypass covers local JWT testing.
  - TODO later: role-based authz (legacy uses roles like `Clerk_Orders`), LDAPS
    (port 636) in prod, strong signing key via secret store.
- **LDAP deployment context (IMPORTANT):**
  - **Live endpoint:** `LDAP://136.174.21.56:389` (plain LDAP, port 389). The
    legacy `Web.config` DNS value can be stale; this IP is the current target.
    Set in `appsettings.json` -> `Ldap:Server`/`Port` (configurable = future
    owner/endpoint switch is a config edit, not code).
  - **DMZ / network reachability is the real gating factor, not the code.** The
    legacy app runs in the DMZ and may not be permitted to reach the internal LDAP;
    this is why parts of `Login.aspx.vb` (e.g. the `PROD` dev-bypass) are commented
    out and why we see "LDAP server is unavailable" from dev. Wherever `Jaws.Api`
    is hosted must have a firewall path to the live LDAP endpoint. Verify on-network.
  - **LDAP authenticator owners are switching** -> endpoint will likely change;
    keep it config-driven (already done).
- **Login is TWO steps (only step 1 built so far):**
  1. LDAP bind validates the password (DONE).
  2. Legacy also calls `authenticateUser()` + `Roles.GetRolesForUser()` - the user
     must exist with a **role** in the JAWS membership/roles tables, and is routed
     by role (Admin/Judge/Clerk_Orders/Judicial Assistant/Internal_ReadOnly/etc.).
     **Role-based authorization is a first-class requirement**, not optional. Add a
     step to look up JAWS roles after LDAP success and include them as JWT claims.
- **Step 8b (done):** Added the second login step (JAWS role lookup), matching
  legacy `Roles.GetRolesForUser`. New `IUserRoleRepository`/`UserRoleRepository`
  (LINQ-first over `aspnet_Users`/`aspnet_Roles`/`aspnet_UsersInRoles`), registered
  in `AddJawsData`. `AuthController` login is now two-step: LDAP bind -> role lookup
  (403 if no role) -> JWT with role claims; `/me` returns roles. Verified vs real
  DB: `crtx00073` -> role `Admin`, JWT issued with role claim. Build 0/0.
- **API convention alignment (done):** Restructured `Jaws.Api` to mirror the org
  standard **APITemplate_NET8** (kept on .NET 10). Adopted its layout
  (`App_Tools/`, `Services/`, `Models/` + `Models/DTO/`), the generic base stack
  (`_BaseController<T>`/`_BaseService<T>`/`IBaseModel` with soft-delete + audit),
  `AppKey` static config, `AccountController` (`Login`/`Me`, `[Route("[controller]")]`),
  Swagger+Bearer, named CORS, security headers. Kept JAWS''s own LDAP auth (moved to
  `App_Tools`). Verified: login `crtx00073` -> Admin, authed cases/count works,
  Swagger 200. Build 0/0.
  - Deliberately SKIPPED org-specific pieces (per decision): `Controllers/Common`
    settings/permissions, `APIService`/RestSharp central-API calls, `AppUtils.dll`,
    and the refresh-token DB system (no such table in JAWS; kept plain JWT).
  - KEPT `ReportController` as a placeholder for future JAWS reporting.
  - Swashbuckle pinned to 7.2.0 (10.x pulls vulnerable/breaking Microsoft.OpenApi 2.x).
  - Endpoint casing now template-style: `/Account/Login`, `/Account/Me`.
- **Step 9 (done):** Scaffolded the real Nuxt Internal client at `clients/internal/`
  from the org standard **frontend_template_v2** (Nuxt 4, Vuetify 3, axios,
  vee-validate, sweetalert2, vue3-toastify, moment; SPA/ssr:false). Retired the old
  `clients/internal-vue` POC. Adapted for standalone JAWS: `env_variables.js` ->
  JAWS branding + `Jaws.Api` base URL (localhost:5210), JWT-only auth (removed org
  refresh-token/bccApi/central-auth flows), role-based `userProfileService`.
  Built first protected screen `pages/cases/search.vue` + `services/jaws/caseService.js`
  (Vuetify data table -> `/api/cases/search`, guarded by has-token middleware).
  Cleanup: removed org-specific admin/settings/permissions/report/register/forgot
  pages, components, and services; updated nav (Home / Case Search / Help). Verified
  pages compile and serve 200 (login, home, cases/search). node_modules excluded via
  .gitignore; package-lock committed.
  - Frontend is edited in **WebStorm** (separate root `clients/internal/`), backend
    in Visual Studio (`Jaws.slnx`) - no tooling conflict.
  - TODO: full browser click-through login->search in the team environment; JAWS nav
    polish; wire real display name from AD later.
- **Step 9b (done):** End-to-end browser login->Case search VERIFIED. Fixes made:
  (1) login password rule `min:12` -> `required` (strength is AD/LDAP''s job, not the
  form); (2) `axiosService.post` doubled-URL bug (baseUrl + relativeUrl while baseURL
  already set) -> use relativeUrl only; (3) CORS/HTTPS pipeline: run `UseCors` first
  and only `UseHttpsRedirection` outside Development (dev preflight was 307-redirected,
  breaking CORS); (4) login background swapped from CDN city image to a local
  courtroom image (`public/login-background.jpg`).
- **Step 10 (next):** End-to-end browser verification + build out more Case screens
  (details view) and additional data slices as features require.
| Date | Note |
|---|---|
| (initial) | Document created from research/assessment conversation. No code changes made. |
| (update) | Added §3.1 schema decision (keep as-is), §3.2 stored-procedure triage (4 buckets), §5.1 conversion order (bottom-up), and refined §4 + §7. |
| (update) | Resolved: target .NET 10 LTS; layout Option B with `Internal` replacing "Main"; data project `Jaws.Data`. Step 1 implemented (Jaws.Data + Jaws.slnx + EF Core packages, build verified). |
