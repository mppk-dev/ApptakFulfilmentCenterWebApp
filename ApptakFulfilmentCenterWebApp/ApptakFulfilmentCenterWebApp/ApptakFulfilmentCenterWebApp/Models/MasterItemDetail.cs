using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MasterItemDetail
{
    public string Company { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string ProductHighlights { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public decimal Weight { get; set; }

    public decimal Length { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public string? WarrantyType { get; set; }

    public string? WarrantyPeriod { get; set; }

    public string? WarrantyPolicy { get; set; }

    public string WhatsInTheBox { get; set; } = null!;

    public string? UserEntry { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UserModify { get; set; }

    public DateTime? ModifyDate { get; set; }
}
