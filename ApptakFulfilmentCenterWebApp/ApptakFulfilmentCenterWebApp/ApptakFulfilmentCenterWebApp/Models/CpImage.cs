using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpImage
{
    public string Tag { get; set; } = null!;

    public string Id { get; set; } = null!;

    public byte[]? Image { get; set; }

    public DateTime? DateEntry { get; set; }
}
