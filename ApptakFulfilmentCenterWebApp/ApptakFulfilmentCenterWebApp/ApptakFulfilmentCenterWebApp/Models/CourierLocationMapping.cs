using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class CourierLocationMapping
{
    public int CourierMapId { get; set; }

    public int CourierAccountId { get; set; }

    public string CourierLocationName { get; set; } = null!;

    public int CourierLocationId { get; set; }

    public string CourierLocationAddress { get; set; } = null!;
}
