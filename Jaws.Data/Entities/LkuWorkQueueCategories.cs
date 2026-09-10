using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuWorkQueueCategories
{
    public int CategoryId { get; set; }

    public int DivisionId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool? Active { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedUserId { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedUserId { get; set; }

    public string? ColorCode { get; set; }

    public bool? IsPublic { get; set; }
}
