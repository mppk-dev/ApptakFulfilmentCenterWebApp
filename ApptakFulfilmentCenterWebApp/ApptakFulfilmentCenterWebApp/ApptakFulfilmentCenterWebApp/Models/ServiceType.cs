using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ServiceType
{
    public int Id { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? Sname { get; set; }

    public bool? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
