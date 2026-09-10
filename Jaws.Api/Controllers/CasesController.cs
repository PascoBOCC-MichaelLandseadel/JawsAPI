using Jaws.Api.Models.DTO;
using Jaws.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaws.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public sealed class CasesController : ControllerBase
{
    private readonly ICaseRepository _cases;

    public CasesController(ICaseRepository cases) => _cases = cases;

    /// <summary>Total case count (skeleton health/demo).</summary>
    [HttpGet("count")]
    public async Task<ActionResult<int>> GetCount(CancellationToken ct)
        => Ok(await _cases.CountAsync(ct));

    /// <summary>Search cases by (partial) case number.</summary>
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<CaseDto>>> Search(
        [FromQuery] string q, [FromQuery] int max = 25, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(q))
            return Ok(Array.Empty<CaseDto>());

        var results = await _cases.SearchByCaseNumberAsync(q, max, ct);
        var dtos = results.Select(c =>
            new CaseDto(c.CaseId, c.CaseNumber, c.CaseStatus, c.CaseType, c.FiledDate));
        return Ok(dtos);
    }

    /// <summary>Get a single case by id.</summary>
    [HttpGet("{id:int}")]
    public async Task<ActionResult<CaseDto>> GetById(int id, CancellationToken ct)
    {
        var c = await _cases.GetByIdAsync(id, ct);
        return c is null
            ? NotFound()
            : Ok(new CaseDto(c.CaseId, c.CaseNumber, c.CaseStatus, c.CaseType, c.FiledDate));
    }
}