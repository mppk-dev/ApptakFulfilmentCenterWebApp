using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DeliveryChargesMatrix
{
    public int Id { get; set; }

    public string PickUpPointId { get; set; } = null!;

    public string? City { get; set; }

    public double? FromAmount { get; set; }

    public double? ToAmount { get; set; }

    public double? DeliveryCharges { get; set; }

    public string? DeliveryType { get; set; }

    public bool? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public string? CreatedBy { get; set; }

    public int? AddressType { get; set; }
}
