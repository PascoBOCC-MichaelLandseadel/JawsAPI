using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class ApplicationConfig
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}
