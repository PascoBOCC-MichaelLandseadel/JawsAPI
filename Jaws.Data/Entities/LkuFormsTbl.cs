using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuFormsTbl
{
    public byte FormId { get; set; }

    public string? FormDesc { get; set; }

    public short FormType { get; set; }

    public short FormSortId { get; set; }
}
