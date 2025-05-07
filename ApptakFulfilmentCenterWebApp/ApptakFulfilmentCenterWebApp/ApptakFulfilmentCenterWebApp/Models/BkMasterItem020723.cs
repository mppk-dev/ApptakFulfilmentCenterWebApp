using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class BkMasterItem020723
{
    public string Company { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string ItemFullName { get; set; } = null!;

    public string ItemShortName { get; set; } = null!;

    public decimal? NewCost { get; set; }

    public decimal? NewTrade { get; set; }

    public decimal? NewMrsp { get; set; }

    public decimal? OldCost { get; set; }

    public decimal? OldTrade { get; set; }

    public decimal? OldMrsp { get; set; }

    public string? Item1 { get; set; }

    public string? Item1Name { get; set; }

    public string? Item2 { get; set; }

    public string? Item2Name { get; set; }

    public string? Item3 { get; set; }

    public string? Item3Name { get; set; }

    public string? Item4 { get; set; }

    public string? Item4Name { get; set; }

    public string? Item5 { get; set; }

    public string? Item5Name { get; set; }

    public string? Item6 { get; set; }

    public string? Item6Name { get; set; }

    public string? Item7 { get; set; }

    public string? Item7Name { get; set; }

    public string? Item8 { get; set; }

    public string? Item8Name { get; set; }

    public string? Item9 { get; set; }

    public string? Item9Name { get; set; }

    public string? RefCode { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? SellCategory { get; set; }

    public byte[]? Image { get; set; }

    public string? Delivery { get; set; }

    public bool? Prescription { get; set; }

    public string? Seller { get; set; }

    public string? Productlink { get; set; }

    public string? ImageUrl { get; set; }
}
