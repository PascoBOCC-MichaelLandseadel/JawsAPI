using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlTrialWeek
{
    public int TrialWeekId { get; set; }

    public DateTime TrialWeekDateDateTime { get; set; }

    public short MaxCasesDays { get; set; }

    public short Days { get; set; }

    public string? Includes { get; set; }

    public short Division { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ChangeDate { get; set; }

    public virtual ICollection<TblFlPretrialDates> TblFlPretrialDates { get; set; } = new List<TblFlPretrialDates>();
}
