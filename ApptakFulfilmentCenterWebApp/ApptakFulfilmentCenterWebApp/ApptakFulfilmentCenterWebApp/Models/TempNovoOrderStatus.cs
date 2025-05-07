using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TempNovoOrderStatus
{
    public string? OrderNo { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? RequiredBy { get; set; }

    public int? PspStatus { get; set; }

    public int? ApptakStatus { get; set; }

    public string? Value { get; set; }
}
