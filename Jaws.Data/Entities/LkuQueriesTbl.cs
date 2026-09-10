using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuQueriesTbl
{
    public byte QueryId { get; set; }

    public string? QueryDesc { get; set; }

    public short QueryType { get; set; }

    public short QuerySortId { get; set; }
}
