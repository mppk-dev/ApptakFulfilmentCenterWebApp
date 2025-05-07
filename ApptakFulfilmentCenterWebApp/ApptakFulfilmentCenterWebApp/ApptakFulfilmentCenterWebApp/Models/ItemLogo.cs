using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemLogo
{
    public string Company { get; set; } = null!;

    public string Criteria { get; set; } = null!;

    public string CriteriaIn { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateTime? DateModify { get; set; }
}
