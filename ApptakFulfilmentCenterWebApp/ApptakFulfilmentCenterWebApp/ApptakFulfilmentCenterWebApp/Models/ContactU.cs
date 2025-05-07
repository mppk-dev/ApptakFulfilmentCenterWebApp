using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ContactU
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateOnly? DateEntry { get; set; }
}
