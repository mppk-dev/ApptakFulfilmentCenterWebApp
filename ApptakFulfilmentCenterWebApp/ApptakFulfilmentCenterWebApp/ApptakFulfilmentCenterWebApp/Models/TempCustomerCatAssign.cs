using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TempCustomerCatAssign
{
    public string? Company { get; set; }

    public string? SellerId { get; set; }

    public string? SellerLocation { get; set; }

    public string? CustomerId { get; set; }

    public string? CategoryId { get; set; }

    public double? Status { get; set; }

    public string? UserEntry { get; set; }

    public DateTime? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public string? DateModify { get; set; }
}
