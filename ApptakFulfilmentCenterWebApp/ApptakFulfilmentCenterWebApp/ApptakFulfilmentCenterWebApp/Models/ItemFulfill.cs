using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ItemFulfill
{
    public int Id { get; set; }

    public string Company { get; set; } = null!;

    public string DivisionCode { get; set; } = null!;

    public string PrincipalCode { get; set; } = null!;

    public string Fulfillby { get; set; } = null!;

    public string Supportby { get; set; } = null!;

    public string? WarrantyText { get; set; }

    public byte[] Logo { get; set; } = null!;
}
