using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserDocketPreferences
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int DocketIdFromClerk { get; set; }

    public bool IsCriminal { get; set; }

    public bool AutoDisplay { get; set; }

    public bool TopPick { get; set; }
}
