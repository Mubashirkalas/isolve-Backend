using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcmanagementWithPo
{
    public short? PosrNo { get; set; }

    public int? PoNo { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? Bpcode { get; set; }

    public byte? PosubSegmentId { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? OrderedQty { get; set; }

    public double? PoQty { get; set; }

    public double? PoRate { get; set; }

    public double? Popivusd { get; set; }

    public double? PoExchangerate { get; set; }

    public string? Keys { get; set; }

    public short? PoSrno1 { get; set; }

    public virtual LcmanagementMain? KeysNavigation { get; set; }
}
