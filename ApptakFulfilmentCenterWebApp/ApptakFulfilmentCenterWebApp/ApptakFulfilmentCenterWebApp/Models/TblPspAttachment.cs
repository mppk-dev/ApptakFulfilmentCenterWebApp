using System;
using System.Collections.Generic;

namespace ApptakFulfilmentCenterWebApp.Models;

public partial class TblPspAttachment
{
    public string? OrderId { get; set; }

    public byte[]? Img { get; set; }

    public string? ImgDesc { get; set; }

    public decimal? Seq { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
