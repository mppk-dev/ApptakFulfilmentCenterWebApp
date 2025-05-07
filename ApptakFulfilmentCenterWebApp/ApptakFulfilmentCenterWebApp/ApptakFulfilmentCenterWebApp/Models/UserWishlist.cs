using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserWishlist
{
    public string? MasterItem { get; set; }

    public string? ChildItem { get; set; }

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }
}
