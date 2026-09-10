using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlPretrialDates
{
    public int PretrialId { get; set; }

    public int TrialWeekId { get; set; }

    public DateTime PretrialDate { get; set; }

    public int Duration { get; set; }

    public byte MaxNumCases { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ChangeDate { get; set; }

    public virtual TblFlTrialWeek TrialWeek { get; set; } = null!;
}
