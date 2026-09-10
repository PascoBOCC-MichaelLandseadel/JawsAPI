namespace Jaws.Api.Models.DTO;

public sealed record LoginResponse(string Token, string Username, DateTime ExpiresUtc, IReadOnlyList<string> Roles);