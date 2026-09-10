using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseManagerProSeParties
{
    public int ProSePartiesId { get; set; }

    /// <summary>
    /// FK to tbl_CaseManager_ProSe
    /// </summary>
    public int ProSeListId { get; set; }

    public string Pidm { get; set; } = null!;

    /// <summary>
    /// refer to tbl_lku_Party_Type
    /// </summary>
    public int? PartyTypeId { get; set; }

    /// <summary>
    /// FK to tbl_User_Profiles
    /// </summary>
    public int? UserId { get; set; }
}
