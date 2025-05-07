using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OriginCity
{
    public int ID { get; set; }

    public int? CustomeriD { get; set; }

    public int? CityId { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
