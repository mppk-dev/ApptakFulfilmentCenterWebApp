using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CellOrder
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Cnic { get; set; }

    public string? IgiNo { get; set; }

    public string? VitalityNo { get; set; }

    public string? Bank { get; set; }

    public string? ContactNumber { get; set; }

    public string? Address { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? ModelId { get; set; }

    public string? Qty { get; set; }

    public string? Color { get; set; }

    public DateTime? Date { get; set; }

    public bool? IsActive { get; set; }

    public string? ConsignmentNumber { get; set; }

    public string? ExpressCenterId { get; set; }

    public string? ReceiverName { get; set; }

    public string? ReceiverContant { get; set; }
}
