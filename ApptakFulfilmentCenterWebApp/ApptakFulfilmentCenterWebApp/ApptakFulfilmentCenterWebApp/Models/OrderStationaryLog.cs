using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderStationaryLog
{
    public string Company { get; set; } = null!;

    public string StationaryId { get; set; } = null!;

    public int Quantity { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public long OrderId { get; set; }

    public decimal Amount { get; set; }
}
