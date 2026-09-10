using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class ImportRange2
{
    public string? CaseId { get; set; }

    public string? PetitionerName { get; set; }

    public DateTime? DateFiled { get; set; }

    public byte? CaseTypeId { get; set; }

    public string? CaseType { get; set; }

    public byte? Disposition { get; set; }

    public string? DispositionComments { get; set; }

    public DateTime? Letter { get; set; }

    public DateTime? CtDate { get; set; }

    public DateTime? Disposed { get; set; }
}
