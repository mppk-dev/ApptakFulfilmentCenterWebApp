using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CpCustomerOrder
{
    public string Company { get; set; } = null!;

    public string Depot { get; set; } = null!;

    public string Document { get; set; } = null!;

    public string DocNo { get; set; } = null!;

    public string SubDocument { get; set; } = null!;

    public DateOnly DocDate { get; set; }

    public string Customercode { get; set; } = null!;

    public string? Town { get; set; }

    public string? Locality { get; set; }

    public string? Slocality { get; set; }

    public string? Pop { get; set; }

    public string CustomerName { get; set; } = null!;

    public decimal Discount { get; set; }

    public decimal Gst { get; set; }

    public decimal NetAmount { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? DelvDate { get; set; }

    public string? Comments { get; set; }

    public string RefDocument { get; set; } = null!;

    public string RefDocNo { get; set; } = null!;

    public string RefSubDocument { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }

    public string? CustomerAddress { get; set; }

    public string? Cnic { get; set; }

    public string? Strn { get; set; }

    public string? Ntn { get; set; }

    public string? SellerCustCode { get; set; }

    public string? SellerId { get; set; }
}
