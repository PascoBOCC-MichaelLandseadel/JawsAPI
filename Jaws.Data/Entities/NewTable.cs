using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class NewTable
{
    public double? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? FirmName { get; set; }

    public string? Phone { get; set; }

    public string? StreetAddress1 { get; set; }

    public string? StreetAddress2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public double? Zipcode { get; set; }

    public bool EmailMyAlerts { get; set; }

    public double? BarId { get; set; }

    public string? MembershipId { get; set; }
}
