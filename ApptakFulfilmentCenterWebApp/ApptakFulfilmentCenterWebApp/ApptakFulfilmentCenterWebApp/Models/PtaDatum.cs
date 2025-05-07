using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PtaDatum
{
    public string? Make { get; set; }

    public string? Model { get; set; }

    public string? Product { get; set; }

    public string? Color { get; set; }

    public string? Imei1 { get; set; }

    public string? Imei2 { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? WarrantyStarts { get; set; }

    public DateOnly? WarrantyEnds { get; set; }

    public DateOnly? YearOfManufacturing { get; set; }

    public string? WarrantyStatus { get; set; }
}
