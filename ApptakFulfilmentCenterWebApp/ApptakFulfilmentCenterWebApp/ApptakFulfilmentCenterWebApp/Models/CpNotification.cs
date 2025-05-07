using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpNotification
{
    public string Company { get; set; } = null!;

    public string NotifyId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public TimeOnly FiredOn { get; set; }

    public string Status { get; set; } = null!;

    public string UserEntry { get; set; } = null!;

    public DateOnly DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }

    public string? NotifyTitle { get; set; }

    public byte[]? NotifyImage { get; set; }
}
