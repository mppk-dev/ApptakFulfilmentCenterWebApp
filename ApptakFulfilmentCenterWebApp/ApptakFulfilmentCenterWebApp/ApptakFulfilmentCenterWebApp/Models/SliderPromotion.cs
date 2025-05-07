using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SliderPromotion
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string? StoreType { get; set; }

    public byte[]? Image { get; set; }

    public string? ImageName { get; set; }
}
