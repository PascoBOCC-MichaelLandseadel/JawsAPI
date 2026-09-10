namespace Jaws.Api.Models.DTO;

/// <summary>Lightweight case representation returned by the API.</summary>
public sealed record CaseDto(
    int CaseId,
    string CaseNumber,
    string? CaseStatus,
    string? CaseType,
    DateTime? FiledDate);