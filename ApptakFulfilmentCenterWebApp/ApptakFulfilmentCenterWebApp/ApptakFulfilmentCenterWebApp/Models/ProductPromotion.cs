using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ProductPromotion
{
    public int Id { get; set; }

    public string PromotionId { get; set; } = null!;

    public string? ProductCode { get; set; }

    public string? Units { get; set; }

    public string? PromotionProductcode { get; set; }

    public string? FreeUnits { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
