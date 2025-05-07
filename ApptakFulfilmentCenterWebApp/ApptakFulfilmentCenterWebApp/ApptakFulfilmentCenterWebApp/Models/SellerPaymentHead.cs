using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellerPaymentHead
{
    public string Company { get; set; } = null!;

    public string Seller { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public DateOnly DocumentDate { get; set; }

    public string PaymentPeriod { get; set; } = null!;

    public decimal? NetAmount { get; set; }

    public string? Comments { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
