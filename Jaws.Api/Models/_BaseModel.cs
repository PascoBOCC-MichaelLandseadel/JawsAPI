namespace Jaws.Api.Models;

/// <summary>
/// Optional base contract for API models (template convention). JAWS scaffolded
/// entities do not implement this (their schema/PKs vary); use for new API-owned
/// models that want audit + soft-delete semantics.
/// </summary>
public interface IBaseModel
{
    int Id { get; set; }
    DateTime TsCreated { get; set; }
    DateTime TsUpdated { get; set; }
    DateTime? TsRemoved { get; set; }
}