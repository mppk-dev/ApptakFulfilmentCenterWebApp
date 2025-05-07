using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellerOrder
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ConsigneeAddress { get; set; }

    public string? ConsigneeMobileNo { get; set; }

    public string? ConsigneeEmail { get; set; }

    public int? ConsigneerClientId { get; set; }

    public string? ConsignerAccountNo { get; set; }

    public int CustomerId { get; set; }

    public string? ConsignerName { get; set; }

    public string? ConsignerAddress { get; set; }

    public string? OriginCity { get; set; }

    public string? DestinationCity { get; set; }

    public string? Weight { get; set; }

    public string? Pieces { get; set; }

    public decimal? Codamount { get; set; }

    public string? CodreferenceNo { get; set; }

    public string? ServiceType { get; set; }

    public string? SpecialHandling { get; set; }

    public string? ProductDetail { get; set; }

    public string? Remarks { get; set; }

    public string? ConsignmentNumber { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public int? OrderStatus { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }

    public int? Area { get; set; }

    public int? City { get; set; }

    public string? OrderReference { get; set; }

    public string? EntryType { get; set; }

    public int? FCentre { get; set; }

    public string? AddressLabelStatus { get; set; }

    public string? LoadSheetStatus { get; set; }
}
