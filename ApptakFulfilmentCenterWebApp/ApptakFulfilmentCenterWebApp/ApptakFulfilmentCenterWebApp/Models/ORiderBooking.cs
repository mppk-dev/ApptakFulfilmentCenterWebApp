using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ORiderBooking
{
    public decimal UserId { get; set; }

    public long MasterorderId { get; set; }

    public DateOnly OrderPickupDate { get; set; }

    public DateOnly? OrderDeliveryDate { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
