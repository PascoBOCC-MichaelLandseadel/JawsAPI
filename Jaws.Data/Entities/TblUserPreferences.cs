using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserPreferences
{
    public int UserId { get; set; }

    public bool EmailMyLegalAssistants { get; set; }
}
