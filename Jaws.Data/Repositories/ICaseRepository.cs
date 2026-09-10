using Jaws.Data.Entities;

namespace Jaws.Data.Repositories;

/// <summary>
/// Case data access. LINQ-first: methods use EF Core against the existing
/// JAWSMain schema. No stored procedures are used for these operations
/// (per the data-access policy in docs/modernization-plan.md).
/// </summary>
public interface ICaseRepository
{
    Task<TblCase?> GetByIdAsync(int caseId, CancellationToken ct = default);

    Task<TblCase?> GetByCaseNumberAsync(string caseNumber, CancellationToken ct = default);

    Task<IReadOnlyList<TblCase>> SearchByCaseNumberAsync(string partialCaseNumber, int maxResults = 50, CancellationToken ct = default);

    Task<int> CountAsync(CancellationToken ct = default);
}