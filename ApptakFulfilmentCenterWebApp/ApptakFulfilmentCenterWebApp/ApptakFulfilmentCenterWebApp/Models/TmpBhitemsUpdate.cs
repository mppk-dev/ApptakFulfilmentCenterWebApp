using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpBhitemsUpdate
{
    public double? ItemSkucode { get; set; }

    public string? ItemTypeName { get; set; }

    public double? SumOfInventoryFinal { get; set; }

    public double? Price { get; set; }

    public double? SpecialPrice { get; set; }
}
