using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarDocketEmailed
{
    public DateTime DocketDate { get; set; }

    public int ClerkId { get; set; }

    public DateTime DateEmailed { get; set; }

    public int DivisionId { get; set; }
}
