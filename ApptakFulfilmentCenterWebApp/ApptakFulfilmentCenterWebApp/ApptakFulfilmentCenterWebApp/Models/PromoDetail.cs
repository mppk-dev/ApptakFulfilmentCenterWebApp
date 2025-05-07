using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PromoDetail
{
    public string? PromotionCode { get; set; }

    public string? ChItem { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Capping { get; set; }

    public string? PromotionType { get; set; }

    public decimal? PromotionValue { get; set; }

    public string? Status { get; set; }
}
