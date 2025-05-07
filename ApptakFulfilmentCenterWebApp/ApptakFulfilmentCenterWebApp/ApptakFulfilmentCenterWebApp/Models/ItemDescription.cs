using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemDescription
{
    public string Company { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string DescLabel { get; set; } = null!;

    public string DescDetail { get; set; } = null!;

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual MasterItem1 MasterItem1 { get; set; } = null!;
}
