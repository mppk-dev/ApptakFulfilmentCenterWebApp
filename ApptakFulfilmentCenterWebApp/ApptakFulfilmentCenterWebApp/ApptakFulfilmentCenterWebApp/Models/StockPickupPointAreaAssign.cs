using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class StockPickupPointAreaAssign
{
    public int Id { get; set; }

    public int? Countryid { get; set; }

    public int? Provinceid { get; set; }

    public int? Cityid { get; set; }

    public int? Areaid { get; set; }

    public int? PickupPointId { get; set; }

    public string? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public string? Preference { get; set; }
}
