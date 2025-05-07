using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpBhCitem
{
    public string? Company { get; set; }

    public string? ChItem { get; set; }

    public string? ChItemFullName { get; set; }

    public string? ChItemShortName { get; set; }

    public string? Item { get; set; }

    public string? RefCode { get; set; }

    public double? Status { get; set; }

    public double? UserEntry { get; set; }

    public string? EntryDate { get; set; }

    public double? UserModify { get; set; }

    public string? ModifyDate { get; set; }

    public double? NewCost { get; set; }

    public double? NewTrade { get; set; }

    public double? NewMrsp { get; set; }

    public double? OldCost { get; set; }

    public double? OldTrade { get; set; }

    public double? OldMrsp { get; set; }
}
