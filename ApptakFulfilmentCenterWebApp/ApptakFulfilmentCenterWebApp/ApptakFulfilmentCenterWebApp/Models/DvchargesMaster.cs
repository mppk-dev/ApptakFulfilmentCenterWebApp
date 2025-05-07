using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DvchargesMaster
{
    public string Company { get; set; } = null!;

    public string DvMasterid { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Sdescription { get; set; } = null!;

    public string Ldescription { get; set; } = null!;

    public string? Status { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<DvchargesSetup> DvchargesSetups { get; set; } = new List<DvchargesSetup>();

    public virtual ICollection<DvchargesSlab> DvchargesSlabs { get; set; } = new List<DvchargesSlab>();
}
