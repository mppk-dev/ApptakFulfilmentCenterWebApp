using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderDvchargesDetail
{
    public string Company { get; set; } = null!;

    public int Depotcode { get; set; }

    public long OrderId { get; set; }

    public DateOnly OrderDate { get; set; }

    public string ChItem { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string DvMasterid { get; set; } = null!;

    public double ChargesId { get; set; }

    public double? ApptakCharges { get; set; }

    public double? NextCharges { get; set; }

    public DateTime Createdon { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }

    public virtual OrderHead OrderHead { get; set; } = null!;
}
