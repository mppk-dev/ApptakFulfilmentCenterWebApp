using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxAddCity
{
    public int? CountryId { get; set; }

    public int? ProvinceId { get; set; }

    public int CityId { get; set; }

    public string? CityName { get; set; }

    public string? CityNameTitle { get; set; }

    public string? Status { get; set; }
}
