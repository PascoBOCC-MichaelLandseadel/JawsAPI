using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFormsMortgageForeclosure
{
    public int AllocationCaseId { get; set; }

    public DateTime AffidavitOfCompliance { get; set; }

    public bool ServiceOnDefendants { get; set; }

    public bool NonMilitaryAffidavitFiled { get; set; }

    public DateTime MotionForFinalSummary { get; set; }

    public DateTime AffidavitInSupportOfSj { get; set; }

    public DateTime AffidavitFeesAttorneyFiled { get; set; }

    public DateTime AffidavitReasonableFees { get; set; }

    public DateTime OriginalNote { get; set; }
}
