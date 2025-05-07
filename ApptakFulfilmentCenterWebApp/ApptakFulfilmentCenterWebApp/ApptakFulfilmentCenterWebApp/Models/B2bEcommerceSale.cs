using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class B2bEcommerceSale
{
    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? ContactNumber { get; set; }

    public string? Address { get; set; }

    public string? BuyerNtn { get; set; }

    public string? BuyerStrn { get; set; }

    public string? BuyerCnic { get; set; }

    public string? LeverageCustomerCode { get; set; }

    public string? LeverageCustomerName { get; set; }

    public string? LeverageCashmemo { get; set; }

    public DateTime? LeverageCashmemoDate { get; set; }

    public double? ProductCode { get; set; }

    public string? ProductDesc { get; set; }

    public string? TaxType { get; set; }

    public string? CartonSize { get; set; }

    public double? QuantityInPc { get; set; }

    public double? TradePrice { get; set; }

    public double? MrpincludeTax { get; set; }

    public double? MrpexcludeTax { get; set; }

    public double? GrossAmount { get; set; }

    public double? Discount { get; set; }

    public double? Gst { get; set; }
}
