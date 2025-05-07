using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrderDiscountsStg
{
    public string? EstoreOrderId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public decimal? Amount { get; set; }

    public decimal? DiscountRate { get; set; }

    public int? SequenceId { get; set; }
}
