using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TblImagesItem
{
    public string? Tag { get; set; }

    public byte[]? Image { get; set; }

    public string? Model { get; set; }

    public string? ImageType { get; set; }

    public int? Status { get; set; }

    public DateTime? Entrydate { get; set; }

    public decimal Id { get; set; }

    public string? ImageUrl { get; set; }
}
