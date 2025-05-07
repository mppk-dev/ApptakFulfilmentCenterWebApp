using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ApiEndpoint
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Route { get; set; }

    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
}
