using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class JcalFinalAtty
{
    public int EmailId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? BarId { get; set; }

    public string? Phone { get; set; }

    public string? FirmName { get; set; }

    public DateTime? LastLogin { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool Sent { get; set; }
}
