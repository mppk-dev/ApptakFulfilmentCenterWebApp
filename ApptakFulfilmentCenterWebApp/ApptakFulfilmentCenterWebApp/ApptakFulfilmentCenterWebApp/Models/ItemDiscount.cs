using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemDiscount
{
    public string Company { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string? DiscCode { get; set; }

    public long? Discount { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ChildItem ChildItem { get; set; } = null!;

    public virtual MasterItem1 MasterItem1 { get; set; } = null!;
}
