using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseParties
{
    public int CasePartiesId { get; set; }

    public int? CaseId { get; set; }

    public int? PartyTypeId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? SeqNo { get; set; }

    public string? Association { get; set; }

    public string? Pidm { get; set; }
}
