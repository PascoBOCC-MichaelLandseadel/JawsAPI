using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserSignature
{
    public int UserSignatureId { get; set; }

    public int? UserId { get; set; }

    public byte[]? UserSignature { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdatedDate { get; set; }
}
