using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AddArea
{
    public string Company { get; set; } = null!;

    public int CountryId { get; set; }

    public int ProvinceId { get; set; }

    public int CityId { get; set; }

    public int AreaId { get; set; }

    public string? AreaName { get; set; }

    public string? Status { get; set; }

    public string? GpsCoordinates { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual AddCity AddCity { get; set; } = null!;

    public virtual AddCountry AddCountry { get; set; } = null!;

    public virtual AddProvince AddProvince { get; set; } = null!;

    public virtual Company CompanyNavigation { get; set; } = null!;

    public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
}
