using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblProgressItems
{
    public int Id { get; set; }

    public string? Itemtitle { get; set; }

    public string? Filer { get; set; }

    public string? Filingreqt { get; set; }

    public string? Itemremarks { get; set; }

    public string? Itemreferences { get; set; }

    public string? Notes { get; set; }

    public int? Step { get; set; }

    public int? Domreq { get; set; }

    public int? Patreq { get; set; }

    public int? Kidsreq { get; set; }

    public string? Steppart { get; set; }

    public string? Reqtstatus { get; set; }

    public byte? Completionstatus { get; set; }

    public string? Instructions { get; set; }

    public string? Reqtlevel { get; set; }

    public string? Alternatives { get; set; }

    public int? Precisefiledate { get; set; }
}
