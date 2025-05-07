using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PspCancellationReason
{
    public int? Id { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }
}
