using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class AglAuditApi
{
    public string? OrderId { get; set; }

    public string? ActionName { get; set; }

    public string? MethodName { get; set; }

    public string? Body { get; set; }

    public string? ResponseData { get; set; }

    public string? Username { get; set; }

    public DateTime? AccessDate { get; set; }
}
