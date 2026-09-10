using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwAspnetApplications
{
    public string ApplicationName { get; set; } = null!;

    public string LoweredApplicationName { get; set; } = null!;

    public Guid ApplicationId { get; set; }

    public string? Description { get; set; }
}
