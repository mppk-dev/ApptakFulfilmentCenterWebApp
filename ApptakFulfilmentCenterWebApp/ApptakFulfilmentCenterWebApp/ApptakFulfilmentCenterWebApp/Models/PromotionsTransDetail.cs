using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PromotionsTransDetail
{
    public string? OrderId { get; set; }

    public string? PromotionCode { get; set; }

    public string? ChItem { get; set; }

    public decimal? NewMrsp { get; set; }

    public decimal? ItemQty { get; set; }

    public string? PromotionType { get; set; }

    public decimal? PromotionValue { get; set; }

    public decimal? DiscountAmount { get; set; }

    public DateTime? CreateDate { get; set; }
}
