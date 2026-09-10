using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersCsMcoAttA
{
    public int CsMcoAttAId { get; set; }

    public int? OrderId { get; set; }

    public string? PetitionerCopiesAttA { get; set; }

    public string? RespondentCopiesAttA { get; set; }

    public string? TxtCaseStyle3 { get; set; }

    public string? Txt9 { get; set; }

    public string? Txt10 { get; set; }

    public string? TxtAttADueDate { get; set; }

    public string? TxtAttAChildSupportCurrent { get; set; }

    public string? TxtAttAChildSupportRetro { get; set; }

    public string? TxtAttAChildSupportPeriodic { get; set; }

    public string? TxtAttAAlimonyCurrent { get; set; }

    public string? TxtAttAAlimonyRetro { get; set; }

    public string? TxtAttAAlimonyPeriodic { get; set; }

    public string? TxtAttAOtherCurrent { get; set; }

    public string? TxtAttAOtherRetro { get; set; }

    public string? TxtAttAOtherPeriodic { get; set; }

    public string? TxtAttAFrequency { get; set; }
}
