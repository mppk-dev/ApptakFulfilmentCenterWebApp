using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class LeverageSale
{
    public string? Depot { get; set; }

    public string? Type { get; set; }

    public string? Ntown { get; set; }

    public string? Locality { get; set; }

    public string? Slocality { get; set; }

    public string? Pop { get; set; }

    public string? Cust { get; set; }

    public string? Cminv { get; set; }

    public string? Prdcd { get; set; }

    public string? Batch { get; set; }

    public string? Reccd { get; set; }

    public decimal? Qnty { get; set; }

    public decimal? Bonus { get; set; }

    public decimal? Gramt { get; set; }

    public decimal? BonusAmt { get; set; }

    public decimal? Disc { get; set; }

    public DateOnly? Dbdate { get; set; }

    public decimal? Stax { get; set; }

    public string? Town { get; set; }

    public string? Areatype { get; set; }

    public string? Grpo { get; set; }

    public string? Acgrp { get; set; }

    public string? Letter { get; set; }

    public decimal? Ltrdat { get; set; }

    public string? Pkstrn { get; set; }

    public decimal? Pkstot { get; set; }

    public decimal? Pkstkt { get; set; }

    public string? Reason { get; set; }

    public string? OrderBooker { get; set; }

    public string? Dlman { get; set; }

    public string? Pickno { get; set; }

    public string? Phclass { get; set; }

    public string? Cpclass { get; set; }

    public string? Hcclass { get; set; }

    public decimal? Mrpval { get; set; }

    public string? Batch2 { get; set; }

    public DateOnly? Daymon { get; set; }

    public string? FlagBookby { get; set; }

    public string? PaymentMode { get; set; }

    public string? CashmemoType { get; set; }

    public string? ContractNo { get; set; }

    public string? SellCategory { get; set; }

    public string? Section { get; set; }

    public string? Status { get; set; }

    public double? Ratepunit { get; set; }

    public double? Discpunit { get; set; }

    public double? Taxpunit { get; set; }
}
