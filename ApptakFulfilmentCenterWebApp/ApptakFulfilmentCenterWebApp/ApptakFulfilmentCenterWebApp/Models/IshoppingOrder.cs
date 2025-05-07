using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class IshoppingOrder
{
    public string? OrderId { get; set; }

    public string? Purchaseon { get; set; }

    public string? BillName { get; set; }

    public string? ShipName { get; set; }

    public string? Address { get; set; }

    public string? ContactNo { get; set; }

    public int? CityId { get; set; }

    public string? ShippingCity { get; set; }

    public int AreaId { get; set; }

    public string? AreaName { get; set; }

    public string? ProdId { get; set; }

    public string? ItemDetail { get; set; }

    public string? Quantity { get; set; }

    public decimal? GrossTotal { get; set; }

    public decimal? Codamount { get; set; }

    public string? CodreferenceNo { get; set; }

    public string? StoreName { get; set; }

    public string? PaymentMode { get; set; }

    public string? Cnic { get; set; }

    public string? AccountId { get; set; }

    public string? DeliveryCharges { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public bool? Isprocessed { get; set; }

    public string? OType { get; set; }
}
