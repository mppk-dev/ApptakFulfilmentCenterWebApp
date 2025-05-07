using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ORiderPreferedArea
{
    public decimal Userid { get; set; }

    public int CityId { get; set; }

    public int AreaId { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public string? ModifiedOn { get; set; }
}
