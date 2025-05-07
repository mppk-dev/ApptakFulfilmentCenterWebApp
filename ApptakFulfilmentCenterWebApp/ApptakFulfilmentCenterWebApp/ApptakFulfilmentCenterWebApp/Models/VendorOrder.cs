using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class VendorOrder
{
    public string Company { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public string Purchaseon { get; set; } = null!;

    public string BilledTo { get; set; } = null!;

    public string ShippedTo { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string ContactNo { get; set; } = null!;

    public int CityId { get; set; }

    public string ShippingCity { get; set; } = null!;

    public int AreaId { get; set; }

    public string AreaName { get; set; } = null!;

    public string ProdId { get; set; } = null!;

    public string ItemDetail { get; set; } = null!;

    public string Quantity { get; set; } = null!;

    public decimal ItemPrice { get; set; }

    public decimal GrossTotal { get; set; }

    public decimal Codamount { get; set; }

    public string CodreferenceNo { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string Cnic { get; set; } = null!;

    public decimal AccountId { get; set; }

    public string DeliveryCharges { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime Createdon { get; set; }

    public string Createdby { get; set; } = null!;

    public bool Status { get; set; }

    public string? OType { get; set; }

    public virtual TaUser TaUser { get; set; } = null!;
}
