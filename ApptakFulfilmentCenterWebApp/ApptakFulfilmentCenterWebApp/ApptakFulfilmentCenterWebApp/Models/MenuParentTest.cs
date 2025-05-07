using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MenuParentTest
{
    public int Id { get; set; }

    public string ParentId { get; set; } = null!;

    public string ParentDesc { get; set; } = null!;

    public string ParentUrl { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string UrlStatus { get; set; } = null!;

    public string? MenuIconClass { get; set; }
}
