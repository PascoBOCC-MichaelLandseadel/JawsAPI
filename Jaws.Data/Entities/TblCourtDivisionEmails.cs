using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtDivisionEmails
{
    public int Id { get; set; }

    public int DivisionId { get; set; }

    public string DivisionEmail { get; set; } = null!;

    public bool? Deleted { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedBy { get; set; }
}
