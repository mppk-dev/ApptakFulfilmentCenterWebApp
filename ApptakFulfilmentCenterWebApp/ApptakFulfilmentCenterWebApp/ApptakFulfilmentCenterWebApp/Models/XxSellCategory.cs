using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxSellCategory
{
    public int Id { get; set; }

    public string SellCategoryId { get; set; } = null!;

    public string? SellCategory { get; set; }

    public int? Status { get; set; }
}
