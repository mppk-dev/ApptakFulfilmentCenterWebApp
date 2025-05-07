using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghSkuCode
{
    public string? SghSkuCode1 { get; set; }

    public string? MnpChildItemCode { get; set; }

    public string? MnpMasterItemCode { get; set; }

    public double? Active { get; set; }

    public int? StockQty { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? SkuCategory { get; set; }

    public int? StockQtyEstore { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
