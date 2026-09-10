using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseWatchList
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int CaseId { get; set; }

    public DateTime CreateDate { get; set; }
}
