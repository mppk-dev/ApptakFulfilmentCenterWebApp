using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AddProvince
{
    public string Company { get; set; } = null!;

    public int CountryId { get; set; }

    public int ProvinceId { get; set; }

    public string? ProvinceName { get; set; }

    public string? ProvinceNameTitle { get; set; }

    public string? Status { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<AddArea> AddAreas { get; set; } = new List<AddArea>();

    public virtual ICollection<AddCity> AddCities { get; set; } = new List<AddCity>();

    public virtual AddCountry AddCountry { get; set; } = null!;

    public virtual Company CompanyNavigation { get; set; } = null!;
}
