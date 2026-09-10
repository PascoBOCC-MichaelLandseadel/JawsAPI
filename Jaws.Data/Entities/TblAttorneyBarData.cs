using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblAttorneyBarData
{
    public decimal? BarNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? SuffixName { get; set; }

    public string? Entity { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? PrimaryAreaCode { get; set; }

    public string? PrimaryShortPhone { get; set; }

    public string? SecondaryAreaCode { get; set; }

    public string? SecondaryShortPhone { get; set; }

    public string? Email { get; set; }

    public int? County { get; set; }

    public int? Circuit { get; set; }

    public string? EligibilityStatus { get; set; }

    public string? JudgeType { get; set; }

    public bool? RestrictionStatus { get; set; }
}
