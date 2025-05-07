using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxAddProvince
{
    public int? CountryId { get; set; }

    public int ProvinceId { get; set; }

    public string? ProvinceName { get; set; }

    public string? ProvinceNameTitle { get; set; }

    public string? Status { get; set; }
}
