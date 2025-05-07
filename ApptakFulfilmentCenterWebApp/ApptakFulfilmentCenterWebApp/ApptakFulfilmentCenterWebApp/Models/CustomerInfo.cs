using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CustomerInfo
{
    public int CustomeriD { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public int? MplClientId { get; set; }

    public string? MplAccountNo { get; set; }

    public bool? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public int? BrandId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
