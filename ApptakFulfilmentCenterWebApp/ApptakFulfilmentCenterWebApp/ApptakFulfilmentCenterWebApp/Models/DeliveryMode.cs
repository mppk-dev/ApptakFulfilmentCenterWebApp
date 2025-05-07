using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DeliveryMode
{
    public int Id { get; set; }

    public string? DeliveryMode1 { get; set; }

    public string? DeliveryModeDesc { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public string? Status { get; set; }
}
