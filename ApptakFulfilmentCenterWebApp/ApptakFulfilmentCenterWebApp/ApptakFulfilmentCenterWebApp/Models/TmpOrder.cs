using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpOrder
{
    public string? AglOrder { get; set; }

    public double? ApptakNum { get; set; }

    public string? InvoiceNum { get; set; }
}
