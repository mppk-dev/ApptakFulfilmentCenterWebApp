using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TempItemStock
{
    public string Company { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public string? Warehouse { get; set; }

    public string? StockType { get; set; }

    public string Item { get; set; } = null!;

    public string? RefCode { get; set; }

    public long? Stock { get; set; }

    public bool Status { get; set; }
}
