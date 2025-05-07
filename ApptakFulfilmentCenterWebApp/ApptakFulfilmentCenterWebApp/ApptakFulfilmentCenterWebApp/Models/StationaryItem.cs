using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class StationaryItem
{
    public string Company { get; set; } = null!;

    public string StnItem { get; set; } = null!;

    public string StnItemFullName { get; set; } = null!;

    public string StnItemShortName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public decimal Cost { get; set; }
}
