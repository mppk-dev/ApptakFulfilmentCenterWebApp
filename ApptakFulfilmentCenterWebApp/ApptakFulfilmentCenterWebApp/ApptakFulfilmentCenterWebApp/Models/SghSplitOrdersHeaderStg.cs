using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghSplitOrdersHeaderStg
{
    public string? PartnerOrderId { get; set; }

    public string? ChildOrderId { get; set; }

    public DateTime? CreatedDatetime { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Total { get; set; }

    public string? Currency { get; set; }

    public string? OrderType { get; set; }

    public string? Paymentmode { get; set; }

    public string? DestinationId { get; set; }

    public string? DeliveryMethod { get; set; }

    public string? BaContactName { get; set; }

    public string? BaLine1 { get; set; }

    public string? BaLine2 { get; set; }

    public string? BaCity { get; set; }

    public string? BaState { get; set; }

    public string? BaPostalCode { get; set; }

    public string? BaCompanyName { get; set; }

    public string? BaCountry { get; set; }

    public string? BaContactPhone { get; set; }

    public string? CsCustomerId { get; set; }

    public string? CsName { get; set; }

    public string? CsEmail { get; set; }

    public string? CsCnic { get; set; }

    public string? CsTitle { get; set; }

    public string? CsCompanyName { get; set; }

    public string? CsPhone { get; set; }

    public string? ConsignmentId { get; set; }

    public string? DeliveryOrderId { get; set; }

    public string? Status { get; set; }

    public string? MnpAssignedDepotId { get; set; }

    public string? CancelReason { get; set; }

    public string? ConsignmentNum { get; set; }

    public string? LoadsheetrefNum { get; set; }

    public string? ApptakrefNum { get; set; }

    public DateTime? OrdershippedDt { get; set; }

    public string? OrderCategory { get; set; }

    public string? Cnic { get; set; }

    public DateTime? Createdon { get; set; }
}
