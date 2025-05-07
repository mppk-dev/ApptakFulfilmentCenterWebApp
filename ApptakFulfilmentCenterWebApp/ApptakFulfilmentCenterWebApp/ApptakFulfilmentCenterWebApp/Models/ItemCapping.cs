using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemCapping
{
    public string Company { get; set; } = null!;

    public int CapId { get; set; }

    public string Item { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public string Status { get; set; } = null!;

    public int Quantity { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public string? Modifiedon { get; set; }
}
