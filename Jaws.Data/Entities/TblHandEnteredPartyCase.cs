using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblHandEnteredPartyCase
{
    public int HandEnteredPartyCaseId { get; set; }

    public int? HandEnteredPartyId { get; set; }

    public int? CaseId { get; set; }

    public int? PartyAssociation { get; set; }
}
