using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TmpNovoOrder
{
    public string? OrderNo { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? PatientId { get; set; }

    public DateTime? RequiredBy { get; set; }

    public string? Remarks { get; set; }

    public string? OrderType { get; set; }

    public string? Product { get; set; }

    public string? DepotName { get; set; }

    public string? CityName { get; set; }

    public string? AgentName { get; set; }
}
