using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrderTemplateSave
{
    public int OrderTemplateId { get; set; }

    public int? OrderTypeId { get; set; }

    public string? HtmlContent { get; set; }
}
