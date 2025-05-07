using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghSplitOrderReturn
{
    public string? ChildOrderId { get; set; }

    public string? DeliveryOrderId { get; set; }

    public string? ReasonCode { get; set; }

    public string? Sku { get; set; }

    public int? ReturnedQuantity { get; set; }

    public int? ReceivedQuantity { get; set; }

    public DateTime? Createdon { get; set; }
}
