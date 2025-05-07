using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderDetailLog
{
    public string Company { get; set; } = null!;

    public int Depotcode { get; set; }

    public long OrderId { get; set; }

    public DateOnly OrderDate { get; set; }

    public string ChItem { get; set; } = null!;

    public string Item { get; set; } = null!;

    public long? Quantity { get; set; }

    public string SellCategory { get; set; } = null!;

    public decimal? Amount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Adiscount1 { get; set; }

    public decimal? Adiscount2 { get; set; }

    public decimal? Adiscount3 { get; set; }

    public DateTime Createdon { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }

    public decimal? MrspNew { get; set; }

    public decimal? MrspOld { get; set; }

    public decimal? NewCost { get; set; }

    public byte[]? PrescriptionImg { get; set; }

    public string? PriceTag { get; set; }
}
