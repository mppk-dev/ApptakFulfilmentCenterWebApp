using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmPspOrderDetail
{
    public int Id { get; set; }

    public int? SmPspOrderId { get; set; }

    public string? Sku { get; set; }

    public string? ProdId { get; set; }

    public string? ProdName { get; set; }

    public string? BuName { get; set; }

    public decimal? PspPrice { get; set; }

    public decimal? Units { get; set; }

    public decimal? FreeUnits { get; set; }

    public string? PriceOn { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountPer { get; set; }

    public double? Price { get; set; }

    public double? Amount { get; set; }

    public virtual SmPspOrder? SmPspOrder { get; set; }
}
