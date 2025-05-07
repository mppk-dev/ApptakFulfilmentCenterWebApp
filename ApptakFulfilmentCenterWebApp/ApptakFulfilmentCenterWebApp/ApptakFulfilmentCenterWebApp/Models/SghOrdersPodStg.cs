using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrdersPodStg
{
    public string? ChildOrderId { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverCnic { get; set; }

    public DateTime? DeliveryDateTime { get; set; }
}
