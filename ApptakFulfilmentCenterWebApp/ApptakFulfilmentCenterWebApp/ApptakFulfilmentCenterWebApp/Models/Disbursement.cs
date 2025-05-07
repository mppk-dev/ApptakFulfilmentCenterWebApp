using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class Disbursement
{
    public string InvoiceNo { get; set; } = null!;

    public string Document { get; set; } = null!;

    public int DistributorId { get; set; }

    public DateTime DisbursementDateTime { get; set; }

    public string FocreceiptDate { get; set; } = null!;

    public string FocreceiptNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public int DocumentCategory { get; set; }
}
