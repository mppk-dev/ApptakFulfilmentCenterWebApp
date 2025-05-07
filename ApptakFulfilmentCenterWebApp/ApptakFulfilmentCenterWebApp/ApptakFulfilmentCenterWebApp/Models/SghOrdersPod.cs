using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrdersPod
{
    public string? ChildOrderId { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverCnic { get; set; }

    public DateTime? DeliveryDateTime { get; set; }
}
