using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrderPaymentsStg
{
    public string? EstoreOrderId { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Method { get; set; }

    public string? PaymentResponse { get; set; }

    public string? Amount { get; set; }
}
