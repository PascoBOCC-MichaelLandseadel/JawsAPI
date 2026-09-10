using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrders6thCivilOettrtc
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? CopiesPetitioner { get; set; }

    public string? CopiesRespondent { get; set; }

    public string? JudgeName { get; set; }

    public string? JudgeTitle { get; set; }

    public string? TbCaseNumber { get; set; }

    public string? TbDivision { get; set; }

    public string? Txt1 { get; set; }

    public DateOnly? DateOrderedOn { get; set; }
}
