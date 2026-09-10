using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseWatchlog
{
    public int Id { get; set; }

    public int Fileid { get; set; }

    public DateTime EnteredDate { get; set; }
}
