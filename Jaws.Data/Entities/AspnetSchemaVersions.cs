using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class AspnetSchemaVersions
{
    public string Feature { get; set; } = null!;

    public string CompatibleSchemaVersion { get; set; } = null!;

    public bool IsCurrentVersion { get; set; }
}
