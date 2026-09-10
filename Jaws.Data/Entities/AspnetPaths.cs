using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class AspnetPaths
{
    public Guid ApplicationId { get; set; }

    public Guid PathId { get; set; }

    public string Path { get; set; } = null!;

    public string LoweredPath { get; set; } = null!;

    public virtual AspnetApplications Application { get; set; } = null!;

    public virtual AspnetPersonalizationAllUsers? AspnetPersonalizationAllUsers { get; set; }

    public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; } = new List<AspnetPersonalizationPerUser>();
}
