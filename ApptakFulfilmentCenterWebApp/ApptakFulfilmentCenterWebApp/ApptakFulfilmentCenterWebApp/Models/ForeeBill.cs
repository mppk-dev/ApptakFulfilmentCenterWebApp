using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ForeeBill
{
    public decimal RecId { get; set; }

    public string? BillStatus { get; set; }

    public string? BusinessCrn { get; set; }

    public string? Initiator { get; set; }

    public string? InstrumentInstitution { get; set; }

    public string? InstrumentNumber { get; set; }

    public string? InstrumentType { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? PaymentChannel { get; set; }

    public string? PaymentLink { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public string? TransactionRefId { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
