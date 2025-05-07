using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MasterCategory
{
    public string Company { get; set; } = null!;

    public string McatCode { get; set; } = null!;

    public string McatName { get; set; } = null!;

    public int Sno { get; set; }

    public int? MenuTheme { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public byte[]? McatImage { get; set; }

    public byte[]? McatThumb { get; set; }

    public virtual ICollection<MajorCategory> MajorCategories { get; set; } = new List<MajorCategory>();
}
