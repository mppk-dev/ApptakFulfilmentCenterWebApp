using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpSellerLcatAssign
{
    public string Company { get; set; } = null!;

    public string SellerId { get; set; } = null!;

    public string SellerLocation { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string? Status { get; set; }

    public string? UserEntry { get; set; }

    public DateTime? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
