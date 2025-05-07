using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserLoginAudit
{
    public string? Username { get; set; }

    public string? UserCode { get; set; }

    public DateTime? LoginDt { get; set; }

    public string? WorkstationId { get; set; }
}
