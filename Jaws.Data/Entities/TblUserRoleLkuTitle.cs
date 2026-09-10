using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserRoleLkuTitle
{
    public int TitleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string Title { get; set; } = null!;
}
