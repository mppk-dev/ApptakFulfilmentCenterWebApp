using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class VpblImeiDatum
{
    public int Id { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public string? Product { get; set; }

    public string? Color { get; set; }

    public string? Imei1 { get; set; }

    public string? Imei2 { get; set; }

    public string? SerialNo { get; set; }

    public string? WarrantyStarts { get; set; }

    public string? WarrantyEnds { get; set; }

    public int? YearOfManufacturing { get; set; }

    public DateTime CreatedBy { get; set; }
}
