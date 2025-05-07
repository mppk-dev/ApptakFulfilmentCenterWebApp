using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TempItemCategory
{
    public string Company { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string ScatCode { get; set; } = null!;

    public bool Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }
}
