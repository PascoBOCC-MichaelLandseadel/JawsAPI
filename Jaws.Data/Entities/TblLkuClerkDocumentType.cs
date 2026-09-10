using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuClerkDocumentType
{
    public string? DocumentTypeCode { get; set; }

    public string? DocumentTypeDescription { get; set; }

    public int? UpperDivisionId { get; set; }

    public int TempId { get; set; }
}
