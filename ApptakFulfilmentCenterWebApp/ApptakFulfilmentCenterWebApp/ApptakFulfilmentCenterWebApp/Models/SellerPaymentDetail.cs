using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellerPaymentDetail
{
    public string Company { get; set; } = null!;

    public string Seller { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public DateOnly DocumentDate { get; set; }

    public string OrderNumber { get; set; } = null!;

    public decimal? OrderAmount { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Commission { get; set; }

    public decimal? Penality { get; set; }

    public decimal? Delivery { get; set; }

    public decimal? OtherCharges { get; set; }

    public string? Comments { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }

    public int? PaymentType { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }
}
