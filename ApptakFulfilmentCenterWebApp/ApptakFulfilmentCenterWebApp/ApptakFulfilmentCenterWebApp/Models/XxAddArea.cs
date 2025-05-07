using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxAddArea
{
    public int? CountryId { get; set; }

    public int? ProvinceId { get; set; }

    public int? CityId { get; set; }

    public int AreaId { get; set; }

    public string? AreaName { get; set; }

    public string? Status { get; set; }

    public string? GpsCoordinates { get; set; }
}
