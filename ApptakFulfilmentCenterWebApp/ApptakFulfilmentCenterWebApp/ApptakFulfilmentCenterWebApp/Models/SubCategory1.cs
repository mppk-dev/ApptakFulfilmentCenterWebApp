using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SubCategory1
{
    public int CompanyCode { get; set; }

    public int CategoryCode { get; set; }

    public int SubCategoryCode { get; set; }

    public string SubCategoryName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }
}
