using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
