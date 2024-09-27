using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInvestorRegistration
{
    public byte CompId { get; set; }

    public int SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? ReturnType { get; set; }

    public string? ReturnValue { get; set; }

    public int? GraceDays { get; set; }

    public string? Bpname { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? DealPurchaseSrno { get; set; }

    public string? DealPurchaseSerialNo { get; set; }
}
