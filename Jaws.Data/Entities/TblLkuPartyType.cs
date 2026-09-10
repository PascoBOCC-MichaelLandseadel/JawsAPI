using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuPartyType
{
    public int PartyTypeId { get; set; }

    public string? PartyType { get; set; }

    public bool? Active { get; set; }
}
