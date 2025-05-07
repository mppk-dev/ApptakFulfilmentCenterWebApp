using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PrepaidBillReference
{
    public int Id { get; set; }

    public string PrepaidBillReference1 { get; set; } = null!;

    public string MasterorderIdList { get; set; } = null!;

    public string? PgId { get; set; }
}
