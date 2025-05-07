using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AddCountry
{
    public string Company { get; set; } = null!;

    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryNameTitle { get; set; }

    public string? Status { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<AddArea> AddAreas { get; set; } = new List<AddArea>();

    public virtual ICollection<AddCity> AddCities { get; set; } = new List<AddCity>();

    public virtual ICollection<AddProvince> AddProvinces { get; set; } = new List<AddProvince>();

    public virtual Company CompanyNavigation { get; set; } = null!;
}
