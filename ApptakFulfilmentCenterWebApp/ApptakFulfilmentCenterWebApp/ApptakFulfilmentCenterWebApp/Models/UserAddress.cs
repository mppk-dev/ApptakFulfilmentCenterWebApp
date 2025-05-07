using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class UserAddress
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? FullName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public int? City { get; set; }

    public int? Area { get; set; }

    public int? Province { get; set; }

    public string? ZipCode { get; set; }

    public int? Country { get; set; }

    public string? MobileNumber { get; set; }

    public bool? Isdefault { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public string? AddressIdentification { get; set; }

    public string? OrganizationName { get; set; }
}
