using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblIlAdHocCondition
{
    public int ConditionId { get; set; }

    public string? QueryName { get; set; }

    public string? Username { get; set; }

    public string? FieldName { get; set; }

    public string? DataType { get; set; }

    public string? Operator { get; set; }

    public string? Value { get; set; }
}
