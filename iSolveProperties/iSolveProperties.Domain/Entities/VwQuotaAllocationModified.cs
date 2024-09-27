using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotaAllocationModified
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public int? DpserialNo { get; set; }

    public int? QuotaSerialNo { get; set; }

    public int? QuotaSrno { get; set; }

    public short? Project { get; set; }

    public string? ProjectName { get; set; }

    public string? DealName { get; set; }
}
