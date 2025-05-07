using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class OrderShipment
{
    public decimal OrderId { get; set; }

    public decimal UserCode { get; set; }

    public string? ShipToFirstName { get; set; }

    public string? ShipToPhoneNo { get; set; }

    public string? ShipToAddress1 { get; set; }

    public string? ShipToAddress2 { get; set; }

    public string? ShipToPostalCode { get; set; }

    public string? ShipToCountry { get; set; }

    public string? ShipToProvince { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToArea { get; set; }

    public string? BillToFirstName { get; set; }

    public string? BillToPhoneNo { get; set; }

    public string? BillToAddress1 { get; set; }

    public string? BillToAddress2 { get; set; }

    public string? BillToPostalCode { get; set; }

    public string? BillToCountry { get; set; }

    public string? BillToProvince { get; set; }

    public string? BillToCity { get; set; }

    public string? BillToArea { get; set; }

    public string? ShipmentMethod { get; set; }

    public string? PaymentMethod { get; set; }
}
