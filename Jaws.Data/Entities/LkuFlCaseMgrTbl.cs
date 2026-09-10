using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuFlCaseMgrTbl
{
    public byte CaseMgrId { get; set; }

    public string? CaseMgrDesc { get; set; }

    public string? CaseMgrLogon { get; set; }
}
