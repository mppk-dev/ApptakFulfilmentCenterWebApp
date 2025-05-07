using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TblXiaomiOrder
{
    public int TransactionId { get; set; }

    public int? TransactionType { get; set; }

    public string? ConsignorCode { get; set; }

    public string? ConsignorName { get; set; }

    public string? ConsigneeCode { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ConsigneeAddress { get; set; }

    public string? ConsigneeCity { get; set; }

    public string? Imei { get; set; }

    public string? Sn { get; set; }

    public DateOnly? SellThroughDate { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? DocumentNumber { get; set; }
}
