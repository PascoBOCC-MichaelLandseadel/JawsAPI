using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersCopiedToClerk
{
    public int OrdersCopiedToClerkId { get; set; }

    public string? OrderTitle { get; set; }

    public int? FileId { get; set; }

    public int? OrderId { get; set; }

    public DateTime? DateCopied { get; set; }

    public int? UserId { get; set; }

    public int? DivisionId { get; set; }

    public int? FileSize { get; set; }

    public bool? IsConfidential { get; set; }
}
