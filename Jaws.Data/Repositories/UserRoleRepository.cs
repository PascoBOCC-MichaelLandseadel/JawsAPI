using Jaws.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Jaws.Data.Repositories;

/// <summary>EF Core (LINQ-first) implementation of <see cref="IUserRoleRepository"/>.</summary>
public sealed class UserRoleRepository : IUserRoleRepository
{
    private readonly JawsDbContext _db;

    public UserRoleRepository(JawsDbContext db) => _db = db;

    public async Task<IReadOnlyList<string>> GetRolesForUserAsync(string username, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(username))
            return Array.Empty<string>();

        var lowered = username.ToLowerInvariant();

        return await _db.AspnetUsers
            .AsNoTracking()
            .Where(u => u.LoweredUserName == lowered)
            .SelectMany(u => u.Role.Select(r => r.RoleName))
            .OrderBy(r => r)
            .ToListAsync(ct);
    }

    public Task<bool> UserExistsAsync(string username, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(username))
            return Task.FromResult(false);

        var lowered = username.ToLowerInvariant();
        return _db.AspnetUsers.AsNoTracking().AnyAsync(u => u.LoweredUserName == lowered, ct);
    }
}