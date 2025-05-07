using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserAssignPickuppoint
{
    public int ID { get; set; }

    public int? PickuppointiD { get; set; }

    public string? UserId { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }
}
