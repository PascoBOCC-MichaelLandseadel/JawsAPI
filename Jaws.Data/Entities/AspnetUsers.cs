using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class AspnetUsers
{
    public Guid ApplicationId { get; set; }

    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string LoweredUserName { get; set; } = null!;

    public string? MobileAlias { get; set; }

    public bool IsAnonymous { get; set; }

    public DateTime LastActivityDate { get; set; }

    public virtual AspnetApplications Application { get; set; } = null!;

    public virtual AspnetMembership? AspnetMembership { get; set; }

    public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; } = new List<AspnetPersonalizationPerUser>();

    public virtual AspnetProfile? AspnetProfile { get; set; }

    public virtual ICollection<AspnetRoles> Role { get; set; } = new List<AspnetRoles>();
}
