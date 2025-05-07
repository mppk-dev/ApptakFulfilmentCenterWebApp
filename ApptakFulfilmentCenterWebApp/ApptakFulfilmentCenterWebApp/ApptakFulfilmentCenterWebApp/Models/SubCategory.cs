using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SubCategory
{
    public string Company { get; set; } = null!;

    public string McatCode { get; set; } = null!;

    public string MjcatCode { get; set; } = null!;

    public string ScatCode { get; set; } = null!;

    public string ScatName { get; set; } = null!;

    public int Sno { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public byte[]? ScatImage { get; set; }

    public byte[]? ScatThumb { get; set; }

    public virtual ICollection<ItemCategory> ItemCategories { get; set; } = new List<ItemCategory>();

    public virtual MajorCategory MajorCategory { get; set; } = null!;
}
