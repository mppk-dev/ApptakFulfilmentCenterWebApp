using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class RiderPreferedArea
{
    public string Company { get; set; } = null!;

    public decimal UserId { get; set; }

    public int CountryId { get; set; }

    public int ProvinceId { get; set; }

    public int CityId { get; set; }

    public int AreaId { get; set; }

    public bool Status { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
