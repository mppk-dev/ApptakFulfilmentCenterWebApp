using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemImagesLink
{
    public decimal Id { get; set; }

    public string? Tag { get; set; }

    public string? RefId { get; set; }

    public string? RefType { get; set; }

    public byte[]? RefLink { get; set; }

    public bool? Status { get; set; }

    public string? UserEntry { get; set; }

    public DateTime? DateEntry { get; set; }
}
