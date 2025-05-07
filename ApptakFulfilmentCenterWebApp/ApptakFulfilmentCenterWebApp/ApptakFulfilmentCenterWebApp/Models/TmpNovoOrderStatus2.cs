using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpNovoOrderStatus2
{
    public string? OrderId { get; set; }

    public double? PspOrderId { get; set; }

    public string? F3 { get; set; }

    public string? Distributor { get; set; }

    public string? DocNo { get; set; }

    public DateTime? CashmemoDocDate { get; set; }

    public DateTime? ApptakOrderDate { get; set; }

    public double? UpdatedStatus { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public double? PspStatus { get; set; }

    public bool F12 { get; set; }

    public string? F13 { get; set; }

    public string? DsrCode { get; set; }
}
