using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserProfileAssociatedUsers
{
    public int ParentUserId { get; set; }

    public int ChildUserId { get; set; }

    public DateTime AssociatedDate { get; set; }
}
