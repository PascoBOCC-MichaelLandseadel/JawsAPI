using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUsersCasesDups
{
    public int CaseId { get; set; }

    public int UserId { get; set; }

    public int PartyAssociation { get; set; }
}
