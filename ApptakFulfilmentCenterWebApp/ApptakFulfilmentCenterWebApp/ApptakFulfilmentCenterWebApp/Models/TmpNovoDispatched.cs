using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpNovoDispatched
{
    public string? Distributor { get; set; }

    public string? OrderId { get; set; }

    public string? OrderStatus { get; set; }

    public string? Dsr { get; set; }

    public string? DsrCode { get; set; }
}
