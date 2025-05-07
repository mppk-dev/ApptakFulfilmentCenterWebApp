using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemBundle
{
    public string Company { get; set; } = null!;

    public string ChItem { get; set; } = null!;

    public string Item { get; set; } = null!;

    public long SerialNo { get; set; }

    public string SmItem { get; set; } = null!;

    public int Qty { get; set; }

    public decimal? SmRate { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ChildItem ChildItem { get; set; } = null!;

    public virtual MasterItem1 MasterItem1 { get; set; } = null!;
}
