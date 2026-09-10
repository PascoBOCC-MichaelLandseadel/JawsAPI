using System.DirectoryServices.Protocols;
using System.Net;
using Microsoft.Extensions.Options;

namespace Jaws.Api.App_Tools;

public interface ILdapAuthenticator
{
    /// <summary>Validates credentials by attempting an LDAP bind (mirrors legacy behavior).</summary>
    bool ValidateCredentials(string username, string password);
}

public sealed class LdapAuthenticator : ILdapAuthenticator
{
    private readonly LdapOptions _options;
    private readonly ILogger<LdapAuthenticator> _logger;

    public LdapAuthenticator(IOptions<LdapOptions> options, ILogger<LdapAuthenticator> logger)
    {
        _options = options.Value;
        _logger = logger;
    }

    public bool ValidateCredentials(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return false;

        // Dev-only bypass (mirrors legacy crtx00073 shortcut). Configurable; empty disables.
        if (!string.IsNullOrEmpty(_options.DevBypassUser) &&
            string.Equals(username, _options.DevBypassUser, StringComparison.OrdinalIgnoreCase))
        {
            _logger.LogWarning("LDAP dev-bypass used for {User}", username);
            return true;
        }

        // Strip any domain prefix the user may have typed; we add the configured one.
        var si = username.IndexOf((char)92); var bare = si >= 0 ? username.Substring(si + 1) : username;
        var bindUser = string.IsNullOrEmpty(_options.DomainPrefix) ? bare : _options.DomainPrefix + bare;

        try
        {
            var host = _options.Server
                .Replace("LDAP://", "", StringComparison.OrdinalIgnoreCase)
                .Replace("LDAPS://", "", StringComparison.OrdinalIgnoreCase)
                .TrimEnd('/');

            var identifier = new LdapDirectoryIdentifier(host, _options.Port);
            using var connection = new LdapConnection(identifier)
            {
                AuthType = AuthType.Negotiate
            };
            connection.SessionOptions.ProtocolVersion = 3;
            if (_options.UseSsl)
                connection.SessionOptions.SecureSocketLayer = true;

            connection.Credential = new NetworkCredential(bindUser, password);
            connection.Bind(); // throws if credentials are invalid
            return true;
        }
        catch (LdapException ex)
        {
            _logger.LogInformation("LDAP bind failed for {User}: {Message}", bindUser, ex.Message);
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected LDAP error for {User}", bindUser);
            return false;
        }
    }
}