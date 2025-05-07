using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class VendorPrincipalDiscount
{
    public string Company { get; set; } = null!;

    public decimal Vendor { get; set; }

    public int Type { get; set; }

    public long SchemeNo { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Description { get; set; } = null!;

    public string Item1 { get; set; } = null!;

    public string Item2 { get; set; } = null!;

    public int Discount { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public virtual TaUser TaUser { get; set; } = null!;
}
