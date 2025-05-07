using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class BkSghOrder
{
    public string? EstoreOrderId { get; set; }

    public string? PartnerOrderId { get; set; }

    public DateTime? CreatedDatetime { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Total { get; set; }

    public string? Currency { get; set; }

    public string? OrderType { get; set; }

    public string? DeliveryOrderId { get; set; }

    public string? MnpStatus { get; set; }

    public string? RmsStatus { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }
}
