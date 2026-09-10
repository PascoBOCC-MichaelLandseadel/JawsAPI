namespace Jaws.Data.Repositories;

/// <summary>
/// User/role lookups against the legacy ASP.NET Membership tables
/// (aspnet_Users / aspnet_Roles / aspnet_UsersInRoles). LINQ-first.
/// </summary>
public interface IUserRoleRepository
{
    /// <summary>Returns the role names assigned to a user (empty if user not found).</summary>
    Task<IReadOnlyList<string>> GetRolesForUserAsync(string username, CancellationToken ct = default);

    /// <summary>True if the user exists in the JAWS membership tables.</summary>
    Task<bool> UserExistsAsync(string username, CancellationToken ct = default);
}