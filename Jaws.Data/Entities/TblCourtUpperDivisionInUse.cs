using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtUpperDivisionInUse
{
    public int UpperDivisionId { get; set; }

    public bool InUse { get; set; }
}
