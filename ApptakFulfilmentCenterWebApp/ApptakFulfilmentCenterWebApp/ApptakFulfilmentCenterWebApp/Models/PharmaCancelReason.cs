using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PharmaCancelReason
{
    public int Id { get; set; }

    public string DisplayText { get; set; } = null!;

    public string Value { get; set; } = null!;

    public bool Status { get; set; }
}
