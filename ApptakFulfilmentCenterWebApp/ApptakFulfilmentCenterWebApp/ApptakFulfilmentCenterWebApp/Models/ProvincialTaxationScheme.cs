using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ProvincialTaxationScheme
{
    public int Id { get; set; }

    public int ProvinceId { get; set; }

    public decimal StRate { get; set; }

    public decimal WithholdingRate { get; set; }
}
