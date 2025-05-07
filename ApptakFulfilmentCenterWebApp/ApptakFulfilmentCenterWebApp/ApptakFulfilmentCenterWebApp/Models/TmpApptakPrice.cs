using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpApptakPrice
{
    public string? ChItem { get; set; }

    public string? ChItemFullName { get; set; }

    public double? NewTrade { get; set; }

    public double? NewMrsp { get; set; }

    public double? OldMrsp { get; set; }

    public string? Item { get; set; }
}
