using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CourierService
{
    public string Company { get; set; } = null!;

    public string CourierId { get; set; } = null!;

    public string CourierDesc { get; set; } = null!;

    public bool Status { get; set; }

    public decimal CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
