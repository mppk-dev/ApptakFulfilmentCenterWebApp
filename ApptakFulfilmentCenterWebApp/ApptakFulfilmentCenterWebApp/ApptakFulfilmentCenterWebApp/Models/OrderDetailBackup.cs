using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderDetailBackup
{
    public string? OrderId { get; set; }

    public int CompanyCode { get; set; }

    public decimal UserCode { get; set; }

    public int CategoryCode { get; set; }

    public int SubCategoryCode { get; set; }

    public int BrandCode { get; set; }

    public string ModelCode { get; set; } = null!;

    public double ModelPrice { get; set; }

    public string Status { get; set; } = null!;

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }

    public int? Quantity { get; set; }
}
