using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Slider
{
    public string Id { get; set; } = null!;

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }

    public string? Text3 { get; set; }

    public int? OrderNo { get; set; }

    public string? StoreType { get; set; }

    public string? Url { get; set; }

    public string? Type { get; set; }

    public byte[] Image { get; set; } = null!;

    public string ImageName { get; set; } = null!;

    public string? MobileAppKeyword { get; set; }

    public string? ImageUrl { get; set; }
}
