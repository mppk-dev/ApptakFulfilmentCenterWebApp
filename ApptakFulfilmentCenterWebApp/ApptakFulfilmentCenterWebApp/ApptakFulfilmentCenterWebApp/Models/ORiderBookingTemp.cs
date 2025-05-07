using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ORiderBookingTemp
{
    public string Company { get; set; } = null!;

    public decimal UserId { get; set; }

    public long MasterorderId { get; set; }

    public DateOnly BookingDate { get; set; }

    public DateOnly? PickupDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public bool Status { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public byte[]? DeliveredImage { get; set; }
}
