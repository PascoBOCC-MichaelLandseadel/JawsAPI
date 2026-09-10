using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class AspnetApplications
{
    public string ApplicationName { get; set; } = null!;

    public string LoweredApplicationName { get; set; } = null!;

    public Guid ApplicationId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AspnetMembership> AspnetMembership { get; set; } = new List<AspnetMembership>();

    public virtual ICollection<AspnetPaths> AspnetPaths { get; set; } = new List<AspnetPaths>();

    public virtual ICollection<AspnetRoles> AspnetRoles { get; set; } = new List<AspnetRoles>();

    public virtual ICollection<AspnetUsers> AspnetUsers { get; set; } = new List<AspnetUsers>();
}
