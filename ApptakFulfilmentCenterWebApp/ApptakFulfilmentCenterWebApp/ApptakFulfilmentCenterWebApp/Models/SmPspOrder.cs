using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SmPspOrder
{
    public int Id { get; set; }

    public string? Distributor { get; set; }

    public string? OrderNo { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? OrderTrackingNo { get; set; }

    public decimal? CallId { get; set; }

    public string? PatientId { get; set; }

    public string? PatientName { get; set; }

    public string? PrimaryMobileNo { get; set; }

    public string? CnicNo { get; set; }

    public string? EmailId { get; set; }

    public string? Address { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? PspTerritoryName { get; set; }

    public string? TerritoryName { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Status { get; set; }

    public string? OrderNature { get; set; }

    public int? DocId { get; set; }

    public string? DocName { get; set; }

    public string? DoctorRef { get; set; }

    public string? ClinicName { get; set; }

    public string? Division { get; set; }

    public string? UserEntry { get; set; }

    public DateOnly? DateEntry { get; set; }

    public string? UserModify { get; set; }

    public DateOnly? DateModify { get; set; }

    public string? Comments { get; set; }

    public int? PspTerritoryId { get; set; }

    public DateOnly? RequiredBy { get; set; }

    public string? ProgramCode { get; set; }

    public string? SecondaryMobileNo { get; set; }

    public virtual ICollection<SmPspOrderDetail> SmPspOrderDetails { get; set; } = new List<SmPspOrderDetail>();
}
