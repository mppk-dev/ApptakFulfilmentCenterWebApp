using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmsLog
{
    public int? SmsId { get; set; }

    public string? MobileNo { get; set; }

    public string? ScheduleTime { get; set; }

    public string? Createdby { get; set; }

    public string? Createdon { get; set; }

    public string? Item1 { get; set; }

    public string? Item2 { get; set; }

    public string? ConsigneeName { get; set; }

    public string? Message { get; set; }

    public DateTime? SentOn { get; set; }

    public string? Status { get; set; }
}
