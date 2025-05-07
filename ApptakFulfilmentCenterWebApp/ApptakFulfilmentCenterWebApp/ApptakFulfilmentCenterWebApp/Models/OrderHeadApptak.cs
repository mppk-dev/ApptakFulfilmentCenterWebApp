using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderHeadApptak
{
    public string OrderId { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public DateOnly? OrderDate { get; set; }

    public string? PaymentMode { get; set; }

    public string? DeliveryMode { get; set; }

    public string? Depotcode { get; set; }

    public string? OrderStatus { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Adiscount1 { get; set; }

    public decimal? Adiscount2 { get; set; }

    public decimal? Adiscount3 { get; set; }

    public decimal? DeliveryCharges { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }

    public string? SFullName { get; set; }

    public string? SAddress1 { get; set; }

    public string? SAddress2 { get; set; }

    public string? SZipcode { get; set; }

    public string? SCountry { get; set; }

    public string? SProvince { get; set; }

    public string? SCity { get; set; }

    public string? SArea { get; set; }

    public string? MobileNo { get; set; }

    public string? Remarks { get; set; }
}
