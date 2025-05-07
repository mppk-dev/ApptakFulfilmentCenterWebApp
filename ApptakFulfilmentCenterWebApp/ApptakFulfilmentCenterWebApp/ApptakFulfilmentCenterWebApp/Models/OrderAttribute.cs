using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderAttribute
{
    public long? OrderId { get; set; }

    public string? AttributeName { get; set; }

    public string? AttributeValue { get; set; }
}
