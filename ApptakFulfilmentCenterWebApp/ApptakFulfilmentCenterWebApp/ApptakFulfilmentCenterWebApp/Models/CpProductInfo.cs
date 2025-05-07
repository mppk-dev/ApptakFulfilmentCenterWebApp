using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpProductInfo
{
    public string Company { get; set; } = null!;

    public string SellerId { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string ShortDesc { get; set; } = null!;

    public string LongDesc { get; set; } = null!;

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public double? CartonSize { get; set; }

    public double? Cost { get; set; }

    public double? Trade { get; set; }

    public double? Mrp { get; set; }

    public string? Type { get; set; }

    public string? TaxType { get; set; }

    public double TaxPer { get; set; }

    public string? CategoryId { get; set; }

    public string? CategoryDesc { get; set; }

    public string? ManufacturerId { get; set; }

    public string? Manufacturer { get; set; }

    public string? BrandId { get; set; }

    public string? Brand { get; set; }

    public string? RefCode { get; set; }

    public string? Status { get; set; }

    public string UserEntry { get; set; } = null!;

    public DateOnly DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }

    public string? DivisionId { get; set; }

    public string? Division { get; set; }
}
