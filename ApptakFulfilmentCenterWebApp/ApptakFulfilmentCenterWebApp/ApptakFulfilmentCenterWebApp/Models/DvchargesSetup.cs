using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DvchargesSetup
{
    public string Company { get; set; } = null!;

    public string DvMasterid { get; set; } = null!;

    public double ChargesId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Sdesc { get; set; } = null!;

    public string Ldesc { get; set; } = null!;

    public string? ProjectId { get; set; }

    public string Active { get; set; } = null!;

    public string Claimable { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string Remarks { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual ICollection<DvchargesCriterion> DvchargesCriteria { get; set; } = new List<DvchargesCriterion>();

    public virtual DvchargesMaster DvchargesMaster { get; set; } = null!;

    public virtual ICollection<DvchargesSlab> DvchargesSlabs { get; set; } = new List<DvchargesSlab>();
}
