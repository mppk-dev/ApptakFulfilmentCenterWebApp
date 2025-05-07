using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PaymentGateway
{
    public string Company { get; set; } = null!;

    public string PgId { get; set; } = null!;

    public string? PgDesc { get; set; }

    public decimal? ServiceCharges { get; set; }

    public decimal? Fed { get; set; }

    public bool? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string LogoUrl { get; set; } = null!;
}
