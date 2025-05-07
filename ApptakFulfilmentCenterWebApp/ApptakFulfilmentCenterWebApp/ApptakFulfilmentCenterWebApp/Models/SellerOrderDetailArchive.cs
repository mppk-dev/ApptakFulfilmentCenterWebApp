using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellerOrderDetailArchive
{
    public string? OrderId { get; set; }

    public int BrandCode { get; set; }

    public string? ModelCode { get; set; }

    public string? ProductName { get; set; }

    public double ActualPrice { get; set; }

    public double Gst { get; set; }

    public double Discount { get; set; }

    public double Quantity { get; set; }

    public double TotalAmount { get; set; }

    public bool Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }
}
