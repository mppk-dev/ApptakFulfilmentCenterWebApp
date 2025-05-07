using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderDetailApptak
{
    public string OrderId { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? Item { get; set; }

    public string? ChItem { get; set; }

    public string? Quantity { get; set; }

    public string? SellCategory { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Adiscount1 { get; set; }

    public decimal? Adiscount2 { get; set; }

    public decimal? Adiscount3 { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }
}
