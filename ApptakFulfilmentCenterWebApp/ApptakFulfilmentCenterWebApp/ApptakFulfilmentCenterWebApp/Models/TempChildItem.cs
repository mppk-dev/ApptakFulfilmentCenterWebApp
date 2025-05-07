using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TempChildItem
{
    public string Company { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public string ChItemFullName { get; set; } = null!;

    public string? ChItemShortName { get; set; }

    public string Item { get; set; } = null!;

    public string? RefCode { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public decimal? NewCost { get; set; }

    public decimal? NewTrade { get; set; }

    public decimal? NewMrsp { get; set; }

    public decimal? OldCost { get; set; }

    public decimal? OldTrade { get; set; }

    public decimal? OldMrsp { get; set; }
}
