using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUsersDivisions
{
    public int UserId { get; set; }

    public int DivisionId { get; set; }

    public bool? DefaultDivision { get; set; }
}
