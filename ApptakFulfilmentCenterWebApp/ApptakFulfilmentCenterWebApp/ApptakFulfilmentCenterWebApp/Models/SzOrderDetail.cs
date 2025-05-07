using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SzOrderDetail
{
    public string Company { get; set; } = null!;

    public int SzDetailsId { get; set; }

    public string OrderId { get; set; } = null!;

    public string Depot { get; set; } = null!;

    public string DepotName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string Customername { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public string InvoiceDate { get; set; } = null!;

    public string ReturnType { get; set; } = null!;

    public decimal Invoiceamount { get; set; }

    public decimal Outstanding { get; set; }

    public decimal Gst { get; set; }

    public decimal Discount { get; set; }

    public string? SzStatus { get; set; }
}
