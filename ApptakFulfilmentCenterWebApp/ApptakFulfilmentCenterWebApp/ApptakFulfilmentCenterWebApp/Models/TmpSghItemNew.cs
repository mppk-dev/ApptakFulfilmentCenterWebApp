using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpSghItemNew
{
    public string? SghSkuCode { get; set; }

    public string MnpChildItemCode { get; set; } = null!;

    public double? MnpMasterItemCode { get; set; }

    public double? Active { get; set; }

    public double? StockQty { get; set; }

    public string? LastUpdated { get; set; }

    public string? SkuCategory { get; set; }

    public string? StockQtyEstore { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }
}
