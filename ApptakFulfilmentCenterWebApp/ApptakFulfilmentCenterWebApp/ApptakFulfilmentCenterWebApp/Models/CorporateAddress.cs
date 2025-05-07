using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CorporateAddress
{
    public string Company { get; set; } = null!;

    public int Id { get; set; }

    public string? OrgId { get; set; }

    public string OrganizationName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int CountryId { get; set; }

    public int ProvinceId { get; set; }

    public int CityId { get; set; }

    public int AreaId { get; set; }

    public string Status { get; set; } = null!;

    public string? GpsCoordinates { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
