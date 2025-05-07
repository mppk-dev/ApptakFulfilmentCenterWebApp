using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UplSku
{
    public double? SNo { get; set; }

    public string? Brand { get; set; }

    public double? ProductCode { get; set; }

    public double? MasterItem { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductStatus { get; set; }

    public double? PurchasePrice1 { get; set; }

    public double? TradePrice1 { get; set; }

    public double? ConsumerPrice1 { get; set; }

    public double? NewMrsp { get; set; }

    public double? OldMrsp { get; set; }
}
