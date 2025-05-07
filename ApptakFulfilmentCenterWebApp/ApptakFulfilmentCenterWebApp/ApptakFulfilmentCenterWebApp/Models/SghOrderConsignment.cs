using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrderConsignment
{
    public string? EstoreOrderId { get; set; }

    public string? ConsignmentId { get; set; }

    public string? LineItemId { get; set; }

    public string? Sku { get; set; }

    public decimal? Quantity { get; set; }

    public string? WarehouseId { get; set; }

    public decimal? LineItemTotal { get; set; }

    public decimal? RegularRetailPrice { get; set; }

    public string? TrackingNumber { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? DiscRate { get; set; }

    public decimal? DiscAmount { get; set; }

    public decimal? IncTaxAmount { get; set; }

    public decimal? IncFeeAmount { get; set; }
}
