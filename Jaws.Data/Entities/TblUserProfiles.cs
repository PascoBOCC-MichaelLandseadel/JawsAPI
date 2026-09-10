using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserProfiles
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FirmName { get; set; }

    public string? Phone { get; set; }

    public string? StreetAddress1 { get; set; }

    public string? StreetAddress2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public bool? EmailMyAlerts { get; set; }

    public string? BarId { get; set; }

    public Guid? MembershipId { get; set; }

    public int? Title { get; set; }

    public DateTime? LastUpdated { get; set; }
}
