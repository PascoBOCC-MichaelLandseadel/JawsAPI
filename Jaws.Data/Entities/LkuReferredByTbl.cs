using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuReferredByTbl
{
    public byte ReferredById { get; set; }

    public string? ReferredByDesc { get; set; }
}
