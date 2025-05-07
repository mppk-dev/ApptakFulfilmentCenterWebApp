using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SystemCode
{
    public int Id { get; set; }

    public string? CodeType { get; set; }

    public string? CodeValue { get; set; }

    public string? Identifier { get; set; }

    public string? Year { get; set; }

    public bool? Status { get; set; }
}
