using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblForms
{
    public int FormId { get; set; }

    public string FormName { get; set; } = null!;

    public string FormControlName { get; set; } = null!;
}
