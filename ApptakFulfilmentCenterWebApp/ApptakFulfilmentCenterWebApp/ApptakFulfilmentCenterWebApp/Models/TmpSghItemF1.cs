using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpSghItemF1
{
    public string? SghSkuCode { get; set; }

    public string? MnpChildItemCode { get; set; }

    public double? MnpMasterItemCode { get; set; }

    public double? Active { get; set; }

    public double? StockQty { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? SkuCategory { get; set; }

    public string? StockQtyEstore { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
