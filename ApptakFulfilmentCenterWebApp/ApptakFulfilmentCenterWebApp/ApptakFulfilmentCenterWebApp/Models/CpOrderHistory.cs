using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpOrderHistory
{
    public string CustomerId { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public string Status { get; set; } = null!;

    public string UserEntry { get; set; } = null!;

    public DateTime DateEntry { get; set; }
}
