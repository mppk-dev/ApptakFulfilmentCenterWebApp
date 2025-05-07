using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class MplBookingDetail
{
    public int MplBookingId { get; set; }

    public long MasterorderId { get; set; }

    public string BookingStatus { get; set; } = null!;

    public string Consigneename { get; set; } = null!;

    public string Consigneeaddress { get; set; } = null!;

    public string Consigneemobno { get; set; } = null!;

    public string OriginLocation { get; set; } = null!;

    public string Destinationcity { get; set; } = null!;

    public int Pieces { get; set; }

    public decimal Weight { get; set; }

    public decimal Codamount { get; set; }

    public string Productdetails { get; set; } = null!;

    public string? ConsignmentNo { get; set; }

    public string? LoadsheetNo { get; set; }

    public string? LoadsheetMessage { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ApprovedOn { get; set; }

    public string? AccountId { get; set; }
}
