using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUsersCases
{
    public int CaseId { get; set; }

    public int UserId { get; set; }

    public int PartyAssociation { get; set; }

    public DateTime? AddedDate { get; set; }

    public int? AddedBy { get; set; }
}
