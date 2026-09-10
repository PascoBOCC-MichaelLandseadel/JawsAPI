using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserPreferencesDocTypes
{
    public int? UserId { get; set; }

    public string? CaseTypeCode { get; set; }

    public string? DocumentTypeCode { get; set; }
}
