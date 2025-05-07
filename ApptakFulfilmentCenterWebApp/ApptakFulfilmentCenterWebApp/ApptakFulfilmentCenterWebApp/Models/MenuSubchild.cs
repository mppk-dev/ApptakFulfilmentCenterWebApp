using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MenuSubchild
{
    public string ParentId { get; set; } = null!;

    public string ChildId { get; set; } = null!;

    public string SubchildId { get; set; } = null!;

    public string? SubchildDesc { get; set; }

    public string? SubchildUrl { get; set; }

    public string? Status { get; set; }

    public string? MenuIconClass { get; set; }
}
