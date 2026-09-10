using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuReportsCustomTbl
{
    public int Idnum { get; set; }

    public string? OrderName { get; set; }

    public string? OrderContents { get; set; }

    public string? Username { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
