using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class WebsiteInfo
{
    public int CompanyCode { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyAddress { get; set; }

    public string WebsitName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? OwnerName { get; set; }

    public string? CnicNo { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

    public string? Ntnno { get; set; }

    public string? Strnno { get; set; }
}
