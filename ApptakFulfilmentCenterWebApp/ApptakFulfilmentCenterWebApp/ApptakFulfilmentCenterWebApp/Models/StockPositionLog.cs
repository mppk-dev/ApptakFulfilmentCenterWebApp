using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class StockPositionLog
{
    public int CompanyCode { get; set; }

    public string? ModelCode { get; set; }

    public decimal Units { get; set; }

    public string? Transaction { get; set; }

    public decimal? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }

    public string? RefNo { get; set; }
}
