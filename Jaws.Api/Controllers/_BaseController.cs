using Microsoft.AspNetCore.Mvc;
using Jaws.Api.Services;

namespace Jaws.Api.Controllers;

/// <summary>Generic CRUD controller (template convention).</summary>
public abstract class BaseController<T> : ControllerBase
{
    private readonly IBaseService<T> _service;

    protected BaseController(IBaseService<T> service) => _service = service;

    [HttpGet("GetList")]
    public virtual async Task<IActionResult> GetList() => Ok(await _service.GetList());

    [HttpPost("Create")]
    public virtual async Task<IActionResult> Create(T obj)
    {
        var r = await _service.Create((Models.IBaseModel)obj!);
        if (r != "") return StatusCode(StatusCodes.Status500InternalServerError, r);
        return Ok();
    }

    [HttpPut("Update")]
    public virtual async Task<IActionResult> Update(T obj)
    {
        var r = await _service.Update((Models.IBaseModel)obj!);
        if (r != "") return StatusCode(StatusCodes.Status500InternalServerError, r);
        return Ok();
    }

    [HttpDelete("Remove")]
    public virtual async Task<IActionResult> Remove([FromQuery] int id)
    {
        var r = await _service.Remove(id);
        if (r != "") return StatusCode(StatusCodes.Status500InternalServerError, r);
        return Ok();
    }
}