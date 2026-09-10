using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class Crtmig
{
    public int? BarNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? SuffixName { get; set; }

    public string? Entity { get; set; }

    public string? AddressLine { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? PrimaryPhoneAreaCode { get; set; }

    public string? PrimaryPhoneShortNumber { get; set; }

    public string? SecondaryPhoneAreaCode { get; set; }

    public string? SecondaryPhoneShortNumber { get; set; }

    public string? Email { get; set; }

    public int? County { get; set; }

    public int? Circuit { get; set; }

    public string? ElilgabiltyStatus { get; set; }

    public string? JudgeType { get; set; }
}
