using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class RiderOrderTracking
{
    public string Company { get; set; } = null!;

    public decimal UserId { get; set; }

    public long MasterorderId { get; set; }

    public string Coordinates { get; set; } = null!;

    public DateTime TrackDate { get; set; }

    public virtual RiderBooking RiderBooking { get; set; } = null!;
}
