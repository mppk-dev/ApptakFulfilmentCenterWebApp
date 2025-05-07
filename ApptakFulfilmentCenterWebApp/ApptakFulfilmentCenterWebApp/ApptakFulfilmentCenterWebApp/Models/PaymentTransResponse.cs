using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class PaymentTransResponse
{
    public string Company { get; set; } = null!;

    public int Transactionid { get; set; }

    public string PgId { get; set; } = null!;

    public string? PpAmount { get; set; }

    public string? PpAuthcode { get; set; }

    public string? PpBankid { get; set; }

    public string? PpBillreference { get; set; }

    public string? PpLanguage { get; set; }

    public string? PpMerchantid { get; set; }

    public string? PpResponsecode { get; set; }

    public string? PpResponsemessage { get; set; }

    public string? PpRetreivalreferenceno { get; set; }

    public string? PpSecurehash { get; set; }

    public string? PpSettlementexpiry { get; set; }

    public string? PpSubmerchantid { get; set; }

    public string? PpTxncurrency { get; set; }

    public string? PpTxndatetime { get; set; }

    public string? PpTxnrefno { get; set; }

    public string? PpTxntype { get; set; }

    public string? PpVersion { get; set; }

    public string? Ppmbf1 { get; set; }

    public string? Ppmbf2 { get; set; }

    public string? Ppmbf3 { get; set; }

    public string? Ppmbf4 { get; set; }

    public string? Ppmbf5 { get; set; }

    public string? Ppmpf1 { get; set; }

    public string? Ppmpf2 { get; set; }

    public string? Ppmpf3 { get; set; }

    public string? Ppmpf4 { get; set; }

    public string? Ppmpf5 { get; set; }
}
