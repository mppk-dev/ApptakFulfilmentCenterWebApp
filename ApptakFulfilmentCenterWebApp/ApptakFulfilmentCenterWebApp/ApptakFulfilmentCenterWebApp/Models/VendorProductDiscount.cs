using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class VendorProductDiscount
{
    public string Company { get; set; } = null!;

    public int Type { get; set; }

    public long SchemeNo { get; set; }

    public string Criteria { get; set; } = null!;

    public string In { get; set; } = null!;

    public string Out { get; set; } = null!;

    public decimal RdpAmount { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public virtual VendorPrincipalDiscount VendorPrincipalDiscount { get; set; } = null!;
}
