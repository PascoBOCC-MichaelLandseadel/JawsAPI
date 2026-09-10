namespace Jaws.Api.App_Tools;

/// <summary>LDAP settings (mirrors legacy Web.config keys LDAP_6th_Circuit / WindowsDomain).</summary>
public sealed class LdapOptions
{
    public const string SectionName = "Ldap";

    /// <summary>e.g. "aocpdc1.jud6aoc.org" (host) or full "LDAP://host".</summary>
    public string Server { get; set; } = "";

    /// <summary>LDAP port. 389 = plain/StartTLS, 636 = LDAPS.</summary>
    public int Port { get; set; } = 389;

    /// <summary>Use LDAPS (SSL). Recommended in production.</summary>
    public bool UseSsl { get; set; }

    /// <summary>NetBIOS domain prefix, e.g. "COURT13\".</summary>
    public string DomainPrefix { get; set; } = "";

    /// <summary>Optional dev-only bypass username (validated without LDAP). Empty disables it.</summary>
    public string DevBypassUser { get; set; } = "";
}

/// <summary>JWT signing/issuance settings.</summary>
public sealed class JwtOptions
{
    public const string SectionName = "Jwt";
    public string Issuer { get; set; } = "Jaws.Api";
    public string Audience { get; set; } = "Jaws.Clients";
    /// <summary>Symmetric signing key. Store in user secrets / env - never in source.</summary>
    public string SigningKey { get; set; } = "";
    public int ExpiryMinutes { get; set; } = 60;
}