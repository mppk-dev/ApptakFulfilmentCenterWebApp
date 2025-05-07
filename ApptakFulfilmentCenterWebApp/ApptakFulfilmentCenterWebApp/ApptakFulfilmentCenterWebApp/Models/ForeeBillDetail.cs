using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ForeeBillDetail
{
    public decimal RecId { get; set; }

    public string? BusinessName { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? OutstandingAmount { get; set; }

    public DateTime? InvoiceDueDate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
