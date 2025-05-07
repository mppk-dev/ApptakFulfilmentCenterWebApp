using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class StockPickupPointSellCategory
{
    public int Id { get; set; }

    public int PickupPointid { get; set; }

    public string? SellCategory { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Createdon { get; set; }
}
