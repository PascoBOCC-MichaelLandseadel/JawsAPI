using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserAccountTracking
{
    public int UserId { get; set; }

    public bool EmailVerified { get; set; }

    public int UserCreatedBy { get; set; }

    public int? UserApprovedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public int LastUpdatedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
