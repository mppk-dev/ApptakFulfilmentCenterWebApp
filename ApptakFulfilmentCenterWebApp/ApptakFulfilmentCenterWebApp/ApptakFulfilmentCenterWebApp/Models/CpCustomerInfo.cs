using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpCustomerInfo
{
    public string Company { get; set; } = null!;

    public string SellerId { get; set; } = null!;

    public string SellerLocation { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }

    public string? Owner { get; set; }

    public string? Cnic { get; set; }

    public string? Ntn { get; set; }

    public string? Strn { get; set; }

    public string? DslNo { get; set; }

    public DateOnly? DslExpiry { get; set; }

    public string? DslType { get; set; }

    public string? PrimaryMobileNo { get; set; }

    public string? SecondaryMobileNo { get; set; }

    public string? LandLineNo { get; set; }

    public string? EmailId { get; set; }

    public string? PostCode { get; set; }

    public int? CountryId { get; set; }

    public string? Country { get; set; }

    public int? ProvinceId { get; set; }

    public string? Province { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public int? AreaId { get; set; }

    public string? AreaName { get; set; }

    public string? TownId { get; set; }

    public string? Town { get; set; }

    public string? PoliceStation { get; set; }

    public string? Tehsil { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? RefCustCode1 { get; set; }

    public string? RefCustCode2 { get; set; }

    public string? Password { get; set; }

    public byte[]? Image { get; set; }

    public string? HashKey { get; set; }

    public DateTime? HashExpiry { get; set; }

    public string Status { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string UserEntry { get; set; } = null!;

    public DateTime DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
