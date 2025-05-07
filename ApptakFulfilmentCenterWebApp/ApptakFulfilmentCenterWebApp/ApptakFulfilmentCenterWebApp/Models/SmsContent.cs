using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmsContent
{
    public string Company { get; set; } = null!;

    public int Id { get; set; }

    public string ContentId { get; set; } = null!;

    public string? SmsContent1 { get; set; }

    public int? Status { get; set; }

    public DateTime CreatedOn { get; set; }

    public long CreatedBy { get; set; }
}
