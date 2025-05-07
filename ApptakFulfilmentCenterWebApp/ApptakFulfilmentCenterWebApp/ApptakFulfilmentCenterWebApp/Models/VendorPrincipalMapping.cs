using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class VendorPrincipalMapping
{
    public int VendorPrincipalId { get; set; }

    public string VendorUserCode { get; set; } = null!;

    public string Item1 { get; set; } = null!;

    public string Item2 { get; set; } = null!;
}
