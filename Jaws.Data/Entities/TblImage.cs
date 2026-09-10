using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblImage
{
    public int ImageId { get; set; }

    public string? ImageName { get; set; }

    public byte[]? ImageContent { get; set; }
}
