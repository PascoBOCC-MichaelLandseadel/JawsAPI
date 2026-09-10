using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserCaseEmailAddresses
{
    public int UserCaseEmailId { get; set; }

    public int? CaseId { get; set; }

    public int? UserId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool FromPortal { get; set; }
}
