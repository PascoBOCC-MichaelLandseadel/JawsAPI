using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwAspnetWebPartStatePaths
{
    public Guid ApplicationId { get; set; }

    public Guid PathId { get; set; }

    public string Path { get; set; } = null!;

    public string LoweredPath { get; set; } = null!;
}
