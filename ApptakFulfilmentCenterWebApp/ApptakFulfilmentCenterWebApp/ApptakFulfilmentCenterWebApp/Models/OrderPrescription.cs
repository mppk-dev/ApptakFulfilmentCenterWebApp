using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderPrescription
{
    public string Company { get; set; } = null!;

    public int Depotcode { get; set; }

    public long OrderId { get; set; }

    public string ChItem { get; set; } = null!;

    public string Item { get; set; } = null!;

    public bool? Ispdf { get; set; }

    public byte[]? PrecriptionImg { get; set; }

    public DateOnly? PrescriptionDate { get; set; }

    public string? DoctorName { get; set; }

    public string? DoctorContactNo { get; set; }

    public string? CancelReason { get; set; }

    public DateTime Createdon { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }
}
