using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghConsignmentsError
{
    public string? Estoreorderid { get; set; }

    public string? Errordescription { get; set; }

    public DateTime? Createdon { get; set; }
}
