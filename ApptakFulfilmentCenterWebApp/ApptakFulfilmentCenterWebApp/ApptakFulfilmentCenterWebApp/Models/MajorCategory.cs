using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MajorCategory
{
    public string Company { get; set; } = null!;

    public string McatCode { get; set; } = null!;

    public string MjcatCode { get; set; } = null!;

    public string MjcatName { get; set; } = null!;

    public int Sno { get; set; }

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }

    public byte[]? MjcatImage { get; set; }

    public byte[]? MjcatThumb { get; set; }

    public virtual MasterCategory MasterCategory { get; set; } = null!;

    public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}
