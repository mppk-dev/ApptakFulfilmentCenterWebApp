using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpCustomerCatAssign
{
    public string Company { get; set; } = null!;

    public string SellerId { get; set; } = null!;

    public string SellerLocation { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string UserEntry { get; set; } = null!;

    public DateTime DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
