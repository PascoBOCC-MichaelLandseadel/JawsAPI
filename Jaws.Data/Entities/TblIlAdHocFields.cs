using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblIlAdHocFields
{
    public int FieldId { get; set; }

    public string? FieldName { get; set; }

    public string? FieldDisplayName { get; set; }

    public string? FieldType { get; set; }
}
