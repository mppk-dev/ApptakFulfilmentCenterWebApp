using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UniLever
{
    public double? SNo { get; set; }

    public string? Brand { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductStatus { get; set; }

    public string? TaxType { get; set; }

    public double? GstRegistered { get; set; }

    public double? GstNregistered { get; set; }

    public double? Total { get; set; }

    public double? UnitsInCase { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? DistMarginAge { get; set; }

    public double? PurchasePrice { get; set; }

    public double? TradePrice { get; set; }

    public double? ConsumerPrice { get; set; }

    public double? PurchasePrice1 { get; set; }

    public double? TradePrice1 { get; set; }

    public double? ConsumerPrice1 { get; set; }

    public double? GstPrice { get; set; }

    public double? Gst { get; set; }

    public double? NewMrsp { get; set; }

    public double? OldMrsp { get; set; }
}
