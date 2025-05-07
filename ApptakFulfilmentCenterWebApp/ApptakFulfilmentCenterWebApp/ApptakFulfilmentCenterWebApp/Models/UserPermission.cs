using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserPermission
{
    public string CompanyCode { get; set; } = null!;

    public decimal UserCode { get; set; }

    public int ApiEndpointId { get; set; }

    public string? UserEmail { get; set; }

    public virtual ApiEndpoint ApiEndpoint { get; set; } = null!;

    public virtual TaUser TaUser { get; set; } = null!;
}
