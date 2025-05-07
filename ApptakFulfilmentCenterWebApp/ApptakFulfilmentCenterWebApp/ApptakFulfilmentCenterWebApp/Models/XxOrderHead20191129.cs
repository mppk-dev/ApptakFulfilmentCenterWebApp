using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class XxOrderHead20191129
{
    public string Company { get; set; } = null!;

    public int Depotcode { get; set; }

    public long OrderId { get; set; }

    public DateOnly OrderDate { get; set; }

    public long? MasterorderId { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string DeliveryMode { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public decimal Netamount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Adiscount1 { get; set; }

    public decimal? Adiscount2 { get; set; }

    public decimal? Adiscount3 { get; set; }

    public decimal? DeliveryCharges { get; set; }

    public DateTime Createdon { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }

    public string SFullname { get; set; } = null!;

    public string? SAddress1 { get; set; }

    public string? SAddress2 { get; set; }

    public string SZipcode { get; set; } = null!;

    public string SCountry { get; set; } = null!;

    public string SProvince { get; set; } = null!;

    public string? SCity { get; set; }

    public string? SArea { get; set; }

    public string Mobileno { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateOnly? DelvDate { get; set; }
}
