using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class StockPickuppoint1
{
    public string Company { get; set; } = null!;

    public int Id { get; set; }

    public string? PickupPointId { get; set; }

    public string? PickupPointNameSdesc { get; set; }

    public string? PickupPointNameLdesc { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactNo { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? EmailId { get; set; }

    public string? CityId { get; set; }

    public string? ProvinceId { get; set; }

    public string? CountryId { get; set; }

    public string? Address { get; set; }

    public int? Area { get; set; }
}
