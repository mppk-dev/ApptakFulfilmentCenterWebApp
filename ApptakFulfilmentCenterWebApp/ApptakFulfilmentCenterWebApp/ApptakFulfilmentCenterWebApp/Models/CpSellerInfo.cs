using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpSellerInfo
{
    public string Company { get; set; } = null!;

    public string SellerId { get; set; } = null!;

    public string SellerName { get; set; } = null!;

    public string? MobileNo1 { get; set; }

    public string? MobileNo2 { get; set; }

    public string? PhoneNo1 { get; set; }

    public string? PhoneNo2 { get; set; }

    public string? FaxNo1 { get; set; }

    public string? FaxNo2 { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public string? PostCode { get; set; }

    public int? CountryId { get; set; }

    public string? Country { get; set; }

    public int? ProvinceId { get; set; }

    public string? Province { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public int? AreaId { get; set; }

    public string? AreaName { get; set; }

    public string? PoliceStation { get; set; }

    public string? Tehsil { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Zone { get; set; }

    public string? Ntn { get; set; }

    public string? Strn { get; set; }

    public string? ContactPersonName { get; set; }

    public string? ContactPersonCnic { get; set; }

    public string? ContactPersonDesignation { get; set; }

    public byte[]? Logo { get; set; }

    public string? Status { get; set; }

    public string? UserEntry { get; set; }

    public DateTime? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
