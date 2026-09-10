using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseFilesSigned
{
    public int? FileId { get; set; }

    public int? FileIdOriginal { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateSigned { get; set; }

    public int? DivisionId { get; set; }

    public int? SecSignId { get; set; }

    public DateTime? SecSignDate { get; set; }

    public bool? SignFileServe { get; set; }

    public bool? SignFile { get; set; }

    public bool? Serve { get; set; }
}
