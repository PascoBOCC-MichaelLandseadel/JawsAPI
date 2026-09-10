using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class AspnetPersonalizationAllUsers
{
    public Guid PathId { get; set; }

    public byte[] PageSettings { get; set; } = null!;

    public DateTime LastUpdatedDate { get; set; }

    public virtual AspnetPaths Path { get; set; } = null!;
}
