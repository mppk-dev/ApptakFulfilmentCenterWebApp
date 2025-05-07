using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DvchargesCriterion
{
    public string Company { get; set; } = null!;

    public string DvMasterid { get; set; } = null!;

    public double ChargesId { get; set; }

    public string Criteria { get; set; } = null!;

    public string? CriteriaIn { get; set; }

    public string? CriteriaOut { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public virtual DvchargesSetup DvchargesSetup { get; set; } = null!;
}
