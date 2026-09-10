using Jaws.Api.App_Tools;
using Jaws.Api.Models;
using Jaws.Api.Models.DTO;
using Jaws.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaws.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly ILdapAuthenticator _ldap;
    private readonly ITokenService _tokens;
    private readonly IUserRoleRepository _userRoles;
    private readonly ILogger<AccountController> _logger;

    public AccountController(
        ILdapAuthenticator ldap,
        ITokenService tokens,
        IUserRoleRepository userRoles,
        ILogger<AccountController> logger)
    {
        _ldap = ldap;
        _tokens = tokens;
        _userRoles = userRoles;
        _logger = logger;
    }

    /// <summary>
    /// Two-step login (mirrors legacy JAWS Login.aspx.vb):
    /// 1) validate password via LDAP bind; 2) confirm the user has a JAWS role.
    /// Returns a JWT (with role claims) on success.
    /// </summary>
    [HttpPost("Login")]
    public async Task<ActionResult<LoginResponse>> Login(Login login, CancellationToken ct)
    {
        if (!_ldap.ValidateCredentials(login.Username, login.Password))
            return Unauthorized("Username or password is incorrect");

        var roles = await _userRoles.GetRolesForUserAsync(login.Username, ct);
        if (roles.Count == 0)
        {
            _logger.LogWarning("LDAP ok but no JAWS role for {User}", login.Username);
            return StatusCode(StatusCodes.Status403Forbidden,
                "User is authenticated but has no assigned role in JAWS.");
        }

        var token = _tokens.CreateToken(login.Username, roles);
        var expires = DateTime.UtcNow.AddMinutes(AppKey.JwtExpiryMinutes);
        return Ok(new LoginResponse(token, login.Username, expires, roles));
    }

    /// <summary>Returns the current authenticated user and roles.</summary>
    [Authorize]
    [HttpGet("Me")]
    public ActionResult<object> Me() => Ok(new
    {
        username = User.Identity?.Name,
        roles = User.Claims
            .Where(c => c.Type == System.Security.Claims.ClaimTypes.Role)
            .Select(c => c.Value)
            .ToArray()
    });
}