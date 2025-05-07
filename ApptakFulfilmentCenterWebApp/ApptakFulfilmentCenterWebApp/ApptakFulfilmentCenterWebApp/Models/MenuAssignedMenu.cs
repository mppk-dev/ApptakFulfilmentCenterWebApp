using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MenuAssignedMenu
{
    public string UserType { get; set; } = null!;

    public string ParentId { get; set; } = null!;

    public string? ChildId { get; set; }

    public string? SubchildId { get; set; }

    public string? RCode { get; set; }
}
