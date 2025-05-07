using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ReconcilliationTable
{
    public int ReconId { get; set; }

    public string MasterorderId { get; set; } = null!;

    public string? SalezmanInvoice { get; set; }

    public decimal? SalezmanValue { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
