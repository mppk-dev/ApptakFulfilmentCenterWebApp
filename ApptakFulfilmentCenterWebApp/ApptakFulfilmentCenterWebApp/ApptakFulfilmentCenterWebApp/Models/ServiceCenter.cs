using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class ServiceCenter
{
    public int Id { get; set; }

    public string? Location { get; set; }

    public string? Address { get; set; }

    public string? ContactPerson { get; set; }

    public string? SecondContactPerson { get; set; }

    public string? ThirdContactPerson { get; set; }

    public string? Lat { get; set; }

    public string? Long { get; set; }

    public byte? IsActive { get; set; }

    public DateTime? Date { get; set; }
}
