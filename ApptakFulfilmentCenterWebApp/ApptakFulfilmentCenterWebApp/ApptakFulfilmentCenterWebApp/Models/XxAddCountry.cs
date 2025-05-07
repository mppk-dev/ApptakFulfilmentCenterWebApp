using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxAddCountry
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryNameTitle { get; set; }

    public string? Status { get; set; }
}
