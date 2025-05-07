using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ModelReview
{
    public int? CompanyCode { get; set; }

    public int? CategoryCode { get; set; }

    public int? SubCategoryCode { get; set; }

    public int? BrandCode { get; set; }

    public string? ModelCode { get; set; }

    public string? Quality { get; set; }

    public string? Reviews { get; set; }

    public string? Nickname { get; set; }

    public string? SummaryReviews { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }
}
