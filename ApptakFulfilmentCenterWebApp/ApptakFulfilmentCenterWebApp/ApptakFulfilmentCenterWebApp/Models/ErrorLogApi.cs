using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ErrorLogApi
{
    public long ErrorId { get; set; }

    public string UserId { get; set; } = null!;

    public string? Method { get; set; }

    public string? Query { get; set; }

    public int? Exception { get; set; }

    public int? OrderId { get; set; }

    public DateTime? ErrorTime { get; set; }
}
