using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersGroupNames
{
    public int GroupId { get; set; }

    public int? DivisionId { get; set; }

    public string? GroupName { get; set; }

    public bool? Active { get; set; }
}
