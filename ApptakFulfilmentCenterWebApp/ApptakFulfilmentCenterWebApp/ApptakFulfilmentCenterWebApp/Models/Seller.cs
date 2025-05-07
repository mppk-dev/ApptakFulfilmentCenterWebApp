using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Seller
{
    public string Company { get; set; } = null!;

    public string Seller1 { get; set; } = null!;

    public string SellerName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Website { get; set; }

    public string? Owner { get; set; }

    public string? CnicNo { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string Status { get; set; } = null!;

    public int AreaId { get; set; }

    public int CityId { get; set; }

    public int ProvinceId { get; set; }

    public int CountryId { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? Visibility { get; set; }

    public string? ImageUrl { get; set; }

    public string? StoreType { get; set; }

    public string? FulfillVisibility { get; set; }

    public string? CommissionType { get; set; }

    public decimal? CommissionValue { get; set; }

    public virtual AddArea AddArea { get; set; } = null!;

    public virtual Company CompanyNavigation { get; set; } = null!;
}
