using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLoginNotifications
{
    public int NotificationId { get; set; }

    public string Header { get; set; } = null!;

    public string ContentBox1 { get; set; } = null!;

    public string ContentBox1Style { get; set; } = null!;

    public string ContentBox2 { get; set; } = null!;

    public string ContenctBox2Style { get; set; } = null!;

    public int SequenceNumber { get; set; }
}
