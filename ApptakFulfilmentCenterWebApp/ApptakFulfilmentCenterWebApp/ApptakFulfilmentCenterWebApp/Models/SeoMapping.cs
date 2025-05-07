using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SeoMapping
{
    public int SeoId { get; set; }

    public string? Master { get; set; }

    public string? Major { get; set; }

    public string? Sub { get; set; }

    public string? Item { get; set; }

    public string? Keyword { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedOn { get; set; }
}
