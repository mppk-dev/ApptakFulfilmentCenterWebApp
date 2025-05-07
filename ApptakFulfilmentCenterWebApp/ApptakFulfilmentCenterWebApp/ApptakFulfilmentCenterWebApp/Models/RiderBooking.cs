using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class RiderBooking
{
    public string Company { get; set; } = null!;

    public decimal UserId { get; set; }

    public long MasterorderId { get; set; }

    public DateTime BookingDate { get; set; }

    public DateTime? PickupDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public bool Status { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public byte[]? DeliveredImage { get; set; }

    public string? BookedGps { get; set; }

    public string? PickupGps { get; set; }

    public string? DeliverGps { get; set; }
}
