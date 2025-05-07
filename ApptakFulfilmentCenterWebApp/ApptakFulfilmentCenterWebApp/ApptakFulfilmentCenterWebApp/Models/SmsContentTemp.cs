using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmsContentTemp
{
    public int Id { get; set; }

    public string SmsContentCode { get; set; } = null!;

    public string? SmsContent { get; set; }

    public int? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Createdby { get; set; }
}
