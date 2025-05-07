using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AglSkuCode
{
    public string? SghSkuCode { get; set; }

    public string? MnpChildItemCode { get; set; }

    public string? MnpMasterItemCode { get; set; }

    public double? Active { get; set; }

    public int? StockQty { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? StockQtyEstore { get; set; }
}
