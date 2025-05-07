using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class HitCount
{
    public int? CompanyCode { get; set; }

    public int? CategoryCode { get; set; }

    public int? SubCategoryCode { get; set; }

    public int? BrandCode { get; set; }

    public int? ModelCode { get; set; }

    public DateOnly? EntryDate { get; set; }
}
