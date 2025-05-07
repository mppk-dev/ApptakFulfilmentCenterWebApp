using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellerSetting
{
    public int Id { get; set; }

    public string SellCategory { get; set; } = null!;

    public string CategoryCondition { get; set; } = null!;

    public bool PrepaidDisable { get; set; }

    public bool DoorstepDisable { get; set; }

    public bool SsStatus { get; set; }
}
