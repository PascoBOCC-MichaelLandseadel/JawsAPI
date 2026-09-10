using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuTblUsers
{
    public short Iduser { get; set; }

    public short Userparent { get; set; }

    public string Username { get; set; } = null!;

    public string Role { get; set; } = null!;

    public bool Readonly { get; set; }
}
