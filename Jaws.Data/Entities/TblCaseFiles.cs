using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseFiles
{
    public int FileId { get; set; }

    public int CaseId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string DocumentTitle { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public DateTime UploadedDate { get; set; }

    public int UploadedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Public { get; set; }

    public int? CoverLetterFileId { get; set; }

    public bool? SecondSignature { get; set; }

    public bool? CoverLetterFiled { get; set; }

    public bool? NoSignature { get; set; }

    public bool? Docfile { get; set; }
}
