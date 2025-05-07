using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DvchargesSlab
{
    public string Company { get; set; } = null!;

    public string DvMasterid { get; set; } = null!;

    public double ChargesId { get; set; }

    public double SlabId { get; set; }

    public double CrFrom { get; set; }

    public double CrTo { get; set; }

    public double ApptakDvcharges { get; set; }

    public double? NextDvcharges { get; set; }

    public double? Divider { get; set; }

    public double? PurchaseLimit { get; set; }

    public string Sdesc { get; set; } = null!;

    public string Ldesc { get; set; } = null!;

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual DvchargesMaster DvchargesMaster { get; set; } = null!;

    public virtual DvchargesSetup DvchargesSetup { get; set; } = null!;
}
