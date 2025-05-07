using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpVersion
{
    public string Company { get; set; } = null!;

    public string AppVersion { get; set; } = null!;

    public string ServiceVersion { get; set; } = null!;

    public string ForcedUpdates { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string UserEntry { get; set; } = null!;

    public DateOnly DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }
}
