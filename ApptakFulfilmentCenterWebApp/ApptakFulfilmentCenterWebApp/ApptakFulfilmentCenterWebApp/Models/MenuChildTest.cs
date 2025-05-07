using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MenuChildTest
{
    public int Id { get; set; }

    public string ParentId { get; set; } = null!;

    public string ChildId { get; set; } = null!;

    public string ChildDesc { get; set; } = null!;

    public string ChildUrl { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string UrlStatus { get; set; } = null!;

    public string? MenuIconClass { get; set; }
}
