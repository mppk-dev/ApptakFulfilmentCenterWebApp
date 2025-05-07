using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Menu
{
    public int? CompanyCode { get; set; }

    public int? CategoryCode { get; set; }

    public int ParentCode { get; set; }

    public string? ParentName { get; set; }

    public string? Url { get; set; }

    public string? Status1 { get; set; }
}
