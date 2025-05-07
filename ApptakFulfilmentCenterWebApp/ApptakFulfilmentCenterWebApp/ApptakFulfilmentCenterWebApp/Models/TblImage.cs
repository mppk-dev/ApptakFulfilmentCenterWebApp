using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TblImage
{
    public int Id { get; set; }

    public string? Tag { get; set; }

    public byte[]? Image { get; set; }

    public string? Model { get; set; }
}
