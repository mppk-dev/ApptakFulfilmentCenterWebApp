using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpGrCitem
{
    public string? Company { get; set; }

    public string? ChItem { get; set; }

    public string? F3 { get; set; }

    public string? ChItemFullName { get; set; }

    public string? ChItemShortName { get; set; }

    public string? Item { get; set; }

    public string? RefCode { get; set; }

    public string? Status { get; set; }

    public double? UserEntry { get; set; }

    public string? EntryDate { get; set; }

    public double? UserModify { get; set; }

    public string? ModifyDate { get; set; }

    public string? NewCost { get; set; }

    public string? NewTrade { get; set; }

    public double? NewMrsp { get; set; }

    public string? OldCost { get; set; }

    public string? OldTrade { get; set; }

    public double? OldMrsp { get; set; }
}
