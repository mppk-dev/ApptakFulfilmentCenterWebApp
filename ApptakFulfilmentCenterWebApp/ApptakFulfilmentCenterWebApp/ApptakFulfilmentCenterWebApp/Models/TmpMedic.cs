using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpMedic
{
    public double? MasterOrderId { get; set; }

    public string? OrderDateAndTime { get; set; }

    public string? CustomerName { get; set; }

    public string? City { get; set; }

    public double? NetAmount { get; set; }

    public string? Remarks { get; set; }

    public string? OrderStatus { get; set; }

    public double? OrderRefNo { get; set; }

    public string? F9 { get; set; }

    public string? F10 { get; set; }
}
