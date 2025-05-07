using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ApptakUserRole
{
    public string Company { get; set; } = null!;

    public string RCode { get; set; } = null!;

    public string RName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Division { get; set; } = null!;

    public string? Principal { get; set; }

    public bool? Isvendor { get; set; }

    public string? Vendor { get; set; }

    public string Location { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
