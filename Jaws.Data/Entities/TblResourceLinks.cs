using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblResourceLinks
{
    public int Id { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedBy { get; set; }

    public string? LinkDescription { get; set; }

    public string? LinkUrl { get; set; }
}
