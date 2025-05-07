using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PriceFilter
{
    public int Id { get; set; }

    public int Type { get; set; }

    public int PriceMin { get; set; }

    public int PriceMax { get; set; }

    public string Text { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Status { get; set; }

    public string? McatCode { get; set; }

    public string? MjcatCode { get; set; }

    public string? ScatCode { get; set; }

    public int? Ordernumber { get; set; }
}
