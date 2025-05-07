using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TaxSlab
{
    public string Company { get; set; } = null!;

    public int CountryId { get; set; }

    public int ProvinceId { get; set; }

    public double SalesTaxRate { get; set; }

    public double WithHoldingTaxRate { get; set; }

    public string Status { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
