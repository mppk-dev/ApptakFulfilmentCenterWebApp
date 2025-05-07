using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrderTaxis
{
    public string? EstoreOrderId { get; set; }

    public string? Consignmentid { get; set; }

    public string? Code { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Rate { get; set; }

    public string? Lineitemid { get; set; }

    public string? Sku { get; set; }
}
