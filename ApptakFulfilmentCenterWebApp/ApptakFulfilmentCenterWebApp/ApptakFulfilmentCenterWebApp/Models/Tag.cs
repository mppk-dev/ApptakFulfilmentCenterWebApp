using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Tag
{
    public string TagId { get; set; } = null!;

    public string TagName { get; set; } = null!;

    public string Status { get; set; } = null!;
}
