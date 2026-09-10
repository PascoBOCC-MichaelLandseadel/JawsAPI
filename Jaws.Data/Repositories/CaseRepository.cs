using Jaws.Data.Context;
using Jaws.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jaws.Data.Repositories;

/// <summary>
/// EF Core (LINQ-first) implementation of <see cref="ICaseRepository"/>.
/// </summary>
public sealed class CaseRepository : ICaseRepository
{
    private readonly JawsDbContext _db;

    public CaseRepository(JawsDbContext db) => _db = db;

    public Task<TblCase?> GetByIdAsync(int caseId, CancellationToken ct = default) =>
        _db.TblCase.AsNoTracking().FirstOrDefaultAsync(c => c.CaseId == caseId, ct);

    public Task<TblCase?> GetByCaseNumberAsync(string caseNumber, CancellationToken ct = default) =>
        _db.TblCase.AsNoTracking().FirstOrDefaultAsync(c => c.CaseNumber == caseNumber, ct);

    public async Task<IReadOnlyList<TblCase>> SearchByCaseNumberAsync(string partialCaseNumber, int maxResults = 50, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(partialCaseNumber))
            return Array.Empty<TblCase>();

        return await _db.TblCase.AsNoTracking()
            .Where(c => c.CaseNumber.Contains(partialCaseNumber))
            .OrderBy(c => c.CaseNumber)
            .Take(maxResults)
            .ToListAsync(ct);
    }

    public Task<int> CountAsync(CancellationToken ct = default) =>
        _db.TblCase.AsNoTracking().CountAsync(ct);
}