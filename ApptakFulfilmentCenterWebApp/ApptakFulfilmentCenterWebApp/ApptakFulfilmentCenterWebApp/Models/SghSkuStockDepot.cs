using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghSkuStockDepot
{
    public string? DepotId { get; set; }

    public string? DepotCode { get; set; }

    public string? SghSkuCode { get; set; }

    public string? ChItem { get; set; }

    public decimal? StockQty { get; set; }

    public DateTime? LastUpdated { get; set; }
}
