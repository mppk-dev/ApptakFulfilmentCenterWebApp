using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderHeadBackup
{
    public int CompanyCode { get; set; }

    public decimal OrderId { get; set; }

    public decimal UserCode { get; set; }

    public string SpecialRequests { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }
}
