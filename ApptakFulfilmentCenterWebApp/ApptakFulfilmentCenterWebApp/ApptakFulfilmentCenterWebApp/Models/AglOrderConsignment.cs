using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AglOrderConsignment
{
    public string? ConsignmentId { get; set; }

    public decimal? LineItemId { get; set; }

    public string? Sku { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? TaxRate { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? DiscRate { get; set; }

    public decimal? DiscAmount { get; set; }

    public decimal? IncTaxAmount { get; set; }

    public decimal? IncFeeAmount { get; set; }

    public decimal? LineItemTotal { get; set; }
}
