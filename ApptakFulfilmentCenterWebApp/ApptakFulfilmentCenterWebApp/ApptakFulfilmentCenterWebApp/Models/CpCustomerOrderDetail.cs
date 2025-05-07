using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpCustomerOrderDetail
{
    public string Company { get; set; } = null!;

    public string Depot { get; set; } = null!;

    public string Document { get; set; } = null!;

    public string DocNo { get; set; } = null!;

    public string SubDocument { get; set; } = null!;

    public DateOnly DocDate { get; set; }

    public string Product { get; set; } = null!;

    public string ProductDesc { get; set; } = null!;

    public string? Batch { get; set; }

    public string? Warehouse { get; set; }

    public decimal OrderQty { get; set; }

    public decimal Qty { get; set; }

    public double Amount { get; set; }

    public double Gst { get; set; }

    public double Discount { get; set; }

    public string? RefType { get; set; }

    public string? PriceStruc { get; set; }

    public decimal Otax { get; set; }

    public double? Rate { get; set; }
}
