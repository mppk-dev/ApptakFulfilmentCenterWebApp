using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghSplitOrderReturns27052022
{
    public string? ChildOrderId { get; set; }

    public string? DeliveryOrderId { get; set; }

    public string? ReasonCode { get; set; }

    public string? Sku { get; set; }

    public int? ReturnedQuantity { get; set; }

    public int? ReceivedQuantity { get; set; }
}
