using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemStockLog
{
    public decimal TrId { get; set; }

    public string Company { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public string Item { get; set; } = null!;

    public long? Stock { get; set; }

    public string? RefDocNo { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
