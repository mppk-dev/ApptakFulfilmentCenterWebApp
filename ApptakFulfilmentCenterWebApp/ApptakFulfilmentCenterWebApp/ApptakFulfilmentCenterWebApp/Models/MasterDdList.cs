using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MasterDdList
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string DdKey { get; set; } = null!;

    public string DdText { get; set; } = null!;

    public string DdValue { get; set; } = null!;

    public string DdStatus { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
