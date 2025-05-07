using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghEorderStatus
{
    public int? StatusId { get; set; }

    public string? StatusDescription { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
