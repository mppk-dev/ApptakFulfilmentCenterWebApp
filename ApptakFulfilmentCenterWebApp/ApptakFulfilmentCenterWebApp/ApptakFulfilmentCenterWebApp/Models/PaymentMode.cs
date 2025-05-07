using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PaymentMode
{
    public int Id { get; set; }

    public string? PaymentMode1 { get; set; }

    public string? PaymentModeDesc { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public string? Status { get; set; }
}
