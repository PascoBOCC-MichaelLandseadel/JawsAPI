using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawCaseOrders
{
    public int OrderId { get; set; }

    public string? CaseNumber { get; set; }

    public int? OrderTypeId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedByDivisionId { get; set; }

    public bool? Active { get; set; }

    public int? SignedByUserId { get; set; }

    public DateTime? DateSigned { get; set; }

    public int? _2ndSignatureUserId { get; set; }

    public DateTime? _2ndSignatureDateSigned { get; set; }
}
