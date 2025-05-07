using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class RiderAppDocument
{
    public decimal? DocumentTypeId { get; set; }

    public string? DocumentTypeDesc { get; set; }

    public string? Status { get; set; }
}
