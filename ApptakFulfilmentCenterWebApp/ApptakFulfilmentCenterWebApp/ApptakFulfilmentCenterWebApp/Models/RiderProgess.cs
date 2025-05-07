using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class RiderProgess
{
    public double OrderId { get; set; }

    public string Activity { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
