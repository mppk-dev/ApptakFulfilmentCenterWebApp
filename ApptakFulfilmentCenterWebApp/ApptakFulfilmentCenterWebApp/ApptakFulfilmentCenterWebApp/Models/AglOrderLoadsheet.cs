using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AglOrderLoadsheet
{
    public decimal? LoadsheetNum { get; set; }

    public string? Agilityorderid { get; set; }

    public string? Deliveryorderid { get; set; }

    public string? ConsignmentNum { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? LmdloadsheetNum { get; set; }

    public DateTime? Updatedon { get; set; }
}
