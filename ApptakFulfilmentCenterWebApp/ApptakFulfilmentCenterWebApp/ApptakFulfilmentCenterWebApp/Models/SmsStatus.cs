using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmsStatus
{
    public string Company { get; set; } = null!;

    public long MessageId { get; set; }

    public long MasterorderId { get; set; }

    public string? Recepient { get; set; }

    public string? MessageContent { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ErrorCode { get; set; }

    public string? Error { get; set; }

    public string? ContentId { get; set; }

    public virtual SmsContent? SmsContent { get; set; }
}
