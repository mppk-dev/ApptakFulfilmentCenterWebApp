using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpNovoOrderStatus
{
    public string? OrderId { get; set; }

    public string? PspOrderId { get; set; }

    public string? Distributor { get; set; }

    public string? DocNo { get; set; }

    public DateTime? CashmemoDocDate { get; set; }

    public DateTime? ApptakOrderDate { get; set; }

    public double? UpdatedStatus { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? Dsr { get; set; }

    public string? DsrCode { get; set; }
}
