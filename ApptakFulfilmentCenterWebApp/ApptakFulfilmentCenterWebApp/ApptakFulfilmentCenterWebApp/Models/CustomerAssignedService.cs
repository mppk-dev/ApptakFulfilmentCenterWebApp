using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CustomerAssignedService
{
    public int Id { get; set; }

    public int? CustomeriD { get; set; }

    public int? ServiceId { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
