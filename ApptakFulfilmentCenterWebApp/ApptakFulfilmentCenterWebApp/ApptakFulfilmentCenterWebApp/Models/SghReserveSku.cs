using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghReserveSku
{
    public string? ChildOrderId { get; set; }

    public string? ConsignmentId { get; set; }

    public string? LineItemId { get; set; }

    public string? Sku { get; set; }

    public decimal? Quantity { get; set; }
}
