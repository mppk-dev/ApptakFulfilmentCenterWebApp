using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class User
{
    public string CompanyCode { get; set; } = null!;

    public decimal UserCode { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? PhoneNo { get; set; }

    public string? Birthday { get; set; }

    public string? Gender { get; set; }

    public string? ShippingAddress { get; set; }

    public string? BillingAddress { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? DateEntry { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? City { get; set; }

    public string? Area { get; set; }

    public string? Tempkey { get; set; }

    public DateTime? Keydate { get; set; }

    public string? UserType { get; set; }

    public string? UserCompanyName { get; set; }

    public string? UserCompanyNick { get; set; }

    public string? FullName { get; set; }

    public string? Location { get; set; }
}
