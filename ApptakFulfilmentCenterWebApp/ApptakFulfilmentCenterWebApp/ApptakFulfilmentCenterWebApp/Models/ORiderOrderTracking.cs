using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ORiderOrderTracking
{
    public decimal? Userid { get; set; }

    public long? MasterorderId { get; set; }

    public string? Cordinates { get; set; }

    public DateTime? TrackDate { get; set; }
}
