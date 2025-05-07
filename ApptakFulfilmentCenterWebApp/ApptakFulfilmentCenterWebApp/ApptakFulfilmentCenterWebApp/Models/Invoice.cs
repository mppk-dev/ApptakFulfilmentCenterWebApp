using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Invoice
{
    public string TransactionId { get; set; } = null!;

    public int Distributor { get; set; }

    public int Product { get; set; }

    public int Quantity { get; set; }

    public int Product1 { get; set; }

    public int Quantity1 { get; set; }

    public int Product2 { get; set; }

    public int Quantity2 { get; set; }

    public bool HomeDelivery { get; set; }

    public string DeliveryAddress { get; set; } = null!;

    public DateTime PurchaseDate { get; set; }

    public int PurchaseCount { get; set; }

    public float PurchaseQuantity { get; set; }

    public float Focquantity { get; set; }

    public float FocconsumeQuantity { get; set; }

    public float BalanceQuantity { get; set; }

    public int FoccountAgainstIbreeze { get; set; }

    public string PatientId { get; set; } = null!;

    public string PfizerWyethInvoiceNo { get; set; } = null!;

    public string PfizerOrderNo { get; set; } = null!;

    public int Focquantity1 { get; set; }

    public int FocconsumeQuantity1 { get; set; }

    public int FoccountAgainstPurchase { get; set; }

    public string InstallmentDue { get; set; } = null!;

    public string DocumentCategory { get; set; } = null!;

    public string PatientType { get; set; } = null!;

    public string PatientMobile { get; set; } = null!;

    public string PatientCnic { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public int DoctorId { get; set; }

    public string? PatientName { get; set; }

    public int UploadPdf { get; set; }
}
