using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CourierAccountDetail
{
    public int CourierAccountId { get; set; }

    public string AccountProfileName { get; set; } = null!;

    public string AccountUsername { get; set; } = null!;

    public string AccountPassword { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string AccountSellerCode { get; set; } = null!;
}
