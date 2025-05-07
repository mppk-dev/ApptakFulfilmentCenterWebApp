using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellCategory
{
    public int Id { get; set; }

    public string Company { get; set; } = null!;

    public string SellCategoryId { get; set; } = null!;

    public string? SellCategory1 { get; set; }

    public int? Status { get; set; }

    public string? Seller { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual Company CompanyNavigation { get; set; } = null!;
}
