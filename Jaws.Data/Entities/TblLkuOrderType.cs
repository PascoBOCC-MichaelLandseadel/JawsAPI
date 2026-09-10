using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuOrderType
{
    public int OrderTypeId { get; set; }

    public string? OrderTitle { get; set; }

    public bool? Active { get; set; }

    public int? UserDefinedTypeId { get; set; }

    public string? TemplateFilePath { get; set; }

    public bool? _2ndSignature { get; set; }
}
