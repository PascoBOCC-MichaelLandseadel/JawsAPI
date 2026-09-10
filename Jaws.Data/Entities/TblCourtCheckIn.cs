using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtCheckIn
{
    public int Id { get; set; }

    public int? AllocationCaseId { get; set; }

    public DateTime? CheckinTime { get; set; }

    public int? PageIndex { get; set; }

    public string? CaseNumber { get; set; }

    public string? OpposingCounsel { get; set; }

    public string? CaseRequest { get; set; }

    public string? CaseStatus { get; set; }

    public bool? StateCheckin { get; set; }

    public bool? DefenseCheckin { get; set; }

    public bool? PrivateAttorney { get; set; }

    public bool? Interpreter { get; set; }

    public bool? ProSe { get; set; }

    public bool? InJail { get; set; }

    public string? Soaname { get; set; }

    public string? Soaprogram { get; set; }

    public string? SoajailName { get; set; }
}
