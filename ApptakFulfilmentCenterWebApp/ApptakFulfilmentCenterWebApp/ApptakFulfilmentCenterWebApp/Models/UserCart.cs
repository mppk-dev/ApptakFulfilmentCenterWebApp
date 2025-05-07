using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserCart
{
    public string? MasterItem { get; set; }

    public string? ChildItem { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? Quantity { get; set; }

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }
}
