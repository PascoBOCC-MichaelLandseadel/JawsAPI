using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersFds
{
    public int FdsId { get; set; }

    public int? OrderId { get; set; }

    public string? Txt1 { get; set; }

    public string? Txt3 { get; set; }

    public string? Txt4 { get; set; }

    public string? TxtOther { get; set; }

    public string? TxtDate { get; set; }

    public bool? Rb1 { get; set; }

    public bool? Rb2 { get; set; }

    public bool? Rb3 { get; set; }

    public bool? Rb4 { get; set; }

    public bool? Rb5 { get; set; }

    public bool? Rb6 { get; set; }

    public bool? Rb7 { get; set; }
}
