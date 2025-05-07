using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class BkSghOrderConsignment
{
    public string? EstoreOrderId { get; set; }

    public string? ConsignmentId { get; set; }

    public string? LineItemId { get; set; }

    public string? Sku { get; set; }

    public decimal? Quantity { get; set; }

    public string? WarehouseId { get; set; }

    public decimal? LineItemTotal { get; set; }

    public decimal? RegularRetailPrice { get; set; }
}
