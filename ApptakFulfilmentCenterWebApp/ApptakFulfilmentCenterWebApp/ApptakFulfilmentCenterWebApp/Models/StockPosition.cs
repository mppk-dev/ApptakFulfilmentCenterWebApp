using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class StockPosition
{
    public string? MasterItem { get; set; }

    public string? ChildItem { get; set; }

    public decimal? StockInUnits { get; set; }

    public decimal? StockOutUnits { get; set; }
}
