using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpSalesForecast
{
    public string Createdby { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public string ChItemFullName { get; set; } = null!;

    public long OrderId { get; set; }

    public decimal? Amount { get; set; }
}
