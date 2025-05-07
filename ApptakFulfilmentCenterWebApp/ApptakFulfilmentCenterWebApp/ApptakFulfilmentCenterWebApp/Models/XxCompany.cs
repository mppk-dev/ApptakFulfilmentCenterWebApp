using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxCompany
{
    public string CompanyCode { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? CompanyAddress { get; set; }

    public string WebsitName { get; set; } = null!;

    public string? OwnerName { get; set; }

    public string? CnicNo { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

    public string? Address { get; set; }

    public string? Area { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }
}
