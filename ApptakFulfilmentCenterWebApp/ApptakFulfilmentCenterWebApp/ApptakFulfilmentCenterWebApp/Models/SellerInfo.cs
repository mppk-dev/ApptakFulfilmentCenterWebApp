using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class SellerInfo
{
    public string Company { get; set; } = null!;

    public string Seller { get; set; } = null!;

    public string SellerName { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public string TaxPayer { get; set; } = null!;

    public string? BusinessNtn { get; set; }

    public string? BusinessStrn { get; set; }

    public string? BusinessLocation { get; set; }

    public string? BusinessWarehouse { get; set; }

    public string BusinessReturn { get; set; } = null!;

    public byte[] CnicPic1 { get; set; } = null!;

    public byte[] CnicPic2 { get; set; } = null!;

    public string BankAccountTitle { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankBranch { get; set; } = null!;

    public string BankAccountNo { get; set; } = null!;

    public byte[] BankChequePic { get; set; } = null!;

    public string? Createddby { get; set; }

    public DateTime Createdon { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? UserCode { get; set; }

    public byte[]? Logo { get; set; }
}
