﻿using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SghOrdersLogStg
{
    public string? OrderId { get; set; }

    public string? ActionName { get; set; }

    public string? Body { get; set; }

    public string? Response { get; set; }

    public DateTime? Updateon { get; set; }
}
