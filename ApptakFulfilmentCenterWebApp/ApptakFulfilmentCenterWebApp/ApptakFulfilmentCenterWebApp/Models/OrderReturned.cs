using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderReturned
{
    public string Company { get; set; } = null!;

    public long MasterorderId { get; set; }

    public string CourierService { get; set; } = null!;

    public string ReturnedBy { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ConsignmentNo { get; set; }

    public int ReasonCode { get; set; }
}
