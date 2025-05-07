using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Company
{
    public string Company1 { get; set; } = null!;

    public int Country { get; set; }

    public int Province { get; set; }

    public int City { get; set; }

    public int Area { get; set; }

    public string Sdesc { get; set; } = null!;

    public string Ldesc { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Application { get; set; } = null!;

    public string? OwnerName { get; set; }

    public string? CnicNo { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string Status { get; set; } = null!;

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public virtual ICollection<AddArea> AddAreas { get; set; } = new List<AddArea>();

    public virtual ICollection<AddCity> AddCities { get; set; } = new List<AddCity>();

    public virtual ICollection<AddCountry> AddCountries { get; set; } = new List<AddCountry>();

    public virtual ICollection<AddProvince> AddProvinces { get; set; } = new List<AddProvince>();

    public virtual ICollection<SellCategory> SellCategories { get; set; } = new List<SellCategory>();

    public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
}
