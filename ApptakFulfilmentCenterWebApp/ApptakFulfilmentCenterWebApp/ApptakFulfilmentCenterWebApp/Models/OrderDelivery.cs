using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderDelivery
{
    public string Company { get; set; } = null!;

    public long MasterorderId { get; set; }

    public string CourierService { get; set; } = null!;

    public string DeliveredBy { get; set; } = null!;

    public string? ConsignmentNo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverRelation { get; set; }

    public virtual MasterOrder MasterOrder { get; set; } = null!;
}
