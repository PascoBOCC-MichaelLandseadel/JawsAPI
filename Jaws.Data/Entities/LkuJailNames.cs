using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuJailNames
{
    public int Id { get; set; }

    public string JailName { get; set; } = null!;

    public bool? Deleted { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedUser { get; set; }
}
