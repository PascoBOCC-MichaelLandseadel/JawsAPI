using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblEntityDev
{
    public int Idnum { get; set; }

    public byte? CaseType { get; set; }

    public string? Ffn { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public DateTime? Dob { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? UserName { get; set; }

    public DateTime? ChangeDate { get; set; }
}
