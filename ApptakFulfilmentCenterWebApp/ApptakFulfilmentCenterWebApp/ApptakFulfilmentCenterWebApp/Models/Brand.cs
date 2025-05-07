using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Brand
{
    public int CompanyCode { get; set; }

    public int CategoryCode { get; set; }

    public int SubCategoryCode { get; set; }

    public int BrandCode { get; set; }

    public string BrandName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }

    public byte[]? Image1 { get; set; }

    public byte[]? Image2 { get; set; }

    public string? ReferncePrincipal { get; set; }

    public string? RefernceCategory { get; set; }
}
