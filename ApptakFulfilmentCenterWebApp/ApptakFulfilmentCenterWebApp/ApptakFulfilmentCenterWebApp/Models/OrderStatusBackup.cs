using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderStatusBackup
{
    public int Id { get; set; }

    public string? Orderstatus { get; set; }

    public bool? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
