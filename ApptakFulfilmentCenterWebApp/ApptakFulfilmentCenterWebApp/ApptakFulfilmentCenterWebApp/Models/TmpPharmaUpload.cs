using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpPharmaUpload
{
    public string? SkuCode { get; set; }

    public double? NewMrsp { get; set; }

    public double? OldMrsp { get; set; }

    public string? MasterSku { get; set; }
}
