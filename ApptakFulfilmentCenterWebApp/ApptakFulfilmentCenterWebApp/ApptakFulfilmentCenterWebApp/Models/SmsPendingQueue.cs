using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmsPendingQueue
{
    public int SmsId { get; set; }

    public string? Mobileno { get; set; }

    public DateTime? ScheduleTime { get; set; }

    public string? Createdby { get; set; }

    public string? Createdon { get; set; }

    public string? Item1 { get; set; }

    public string? Item2 { get; set; }

    public string? Consigneename { get; set; }

    public string? Message { get; set; }
}
