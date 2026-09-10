using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblTaskDetail
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Deleted { get; set; }

    public string? Description { get; set; }

    public int? TaskId { get; set; }
}
