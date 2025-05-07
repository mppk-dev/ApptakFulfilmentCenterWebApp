using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MobileAppInfo
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? ThemeColor1 { get; set; }

    public string? ThemeColor2 { get; set; }

    public string? ThemeColor3 { get; set; }

    public string? ThemeColor4 { get; set; }

    public bool? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
