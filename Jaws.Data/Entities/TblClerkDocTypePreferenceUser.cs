using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblClerkDocTypePreferenceUser
{
    public int? UserId { get; set; }

    public int? EventCodeId { get; set; }

    public bool? AutoDisplay { get; set; }

    public bool? TopThreeFavorites { get; set; }
}
