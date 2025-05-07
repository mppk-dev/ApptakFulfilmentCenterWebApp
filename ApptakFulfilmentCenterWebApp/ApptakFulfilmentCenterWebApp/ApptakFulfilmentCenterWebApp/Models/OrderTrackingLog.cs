using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderTrackingLog
{
    public string? OrderId { get; set; }

    public string? OldStatus { get; set; }

    public string? NewStatus { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
