using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblHandEnteredParty
{
    public int HandEnteredPartyId { get; set; }

    public string? Pidm { get; set; }

    public string? Association { get; set; }

    public string? SeqNo { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FirmName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? BarId { get; set; }
}
