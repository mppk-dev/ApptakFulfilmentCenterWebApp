using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class DiscountPrice
{
    public int Id { get; set; }

    public int Productid { get; set; }

    public double? NewPrice { get; set; }

    public double? OldPrice { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int? Noofdays { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Createdon { get; set; }

    public int? Status { get; set; }
}
