using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderStatus
{
    public string Company { get; set; } = null!;

    public int Id { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }
}
