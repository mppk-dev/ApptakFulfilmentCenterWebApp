using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PfzInvoicesHeadDetail
{
    public string PfzInvoicesHeadTransactionId { get; set; } = null!;

    public string? ProdId { get; set; }

    public string? ProdName { get; set; }

    public int? Quantity { get; set; }

    public int Id { get; set; }

    public virtual PfzInvoicesHead PfzInvoicesHeadTransaction { get; set; } = null!;
}
