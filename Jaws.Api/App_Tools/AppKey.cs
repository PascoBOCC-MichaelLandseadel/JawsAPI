namespace Jaws.Api.App_Tools;

/// <summary>
/// Static configuration accessor (template convention). Populated once at startup
/// via GetSection. Secrets still come from user secrets / env vars.
/// </summary>
public static class AppKey
{
    private static IConfiguration _configuration = default!;

    public static void GetSection(IConfiguration configuration) => _configuration = configuration;

    public static string ApplicationName => Setting("AppKey:ApplicationName");
    public static string EnvironmentName => Setting("AppKey:Environment");

    // JWT
    public static string JwtSigningKey => Setting("Jwt:SigningKey");
    public static string JwtIssuer => Setting("Jwt:Issuer");
    public static string JwtAudience => Setting("Jwt:Audience");
    public static int JwtExpiryMinutes => int.TryParse(Setting("Jwt:ExpiryMinutes"), out var v) ? v : 60;

    // LDAP
    public static string LdapServer => Setting("Ldap:Server");
    public static int LdapPort => int.TryParse(Setting("Ldap:Port"), out var v) ? v : 389;
    public static bool LdapUseSsl => bool.TryParse(Setting("Ldap:UseSsl"), out var v) && v;
    public static string LdapDomainPrefix => Setting("Ldap:DomainPrefix");
    public static string LdapDevBypassUser => Setting("Ldap:DevBypassUser");

    public static string Setting(string key) => _configuration.GetSection(key).Value ?? "";
}