using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaws.Api.Controllers;

/// <summary>
/// Placeholder for future JAWS reporting (against the JAWS database). Structure
/// kept from the org API template; JAWS will implement its own report sources
/// rather than calling a central report API.
/// </summary>
[Authorize]
[Route("[controller]")]
[ApiController]
public class ReportController : ControllerBase
{
    // TODO: implement JAWS report endpoints (e.g., run report by name/id against
    // JAWS data; replace legacy Microsoft ReportViewer usage).
}