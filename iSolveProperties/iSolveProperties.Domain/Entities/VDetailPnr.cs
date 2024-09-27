﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VDetailPnr
{
    public string VKey { get; set; } = null!;

    public int SNo { get; set; }

    public string? VType { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? GlCode { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? BillDate { get; set; }

    public double? Qty1 { get; set; }

    public string? Unit1 { get; set; }

    public double? Qty2 { get; set; }

    public string? Unit2 { get; set; }

    public string? CountNo { get; set; }

    public string? InvNo { get; set; }

    public byte? CompId { get; set; }

    public string? VGlyear { get; set; }

    public int? DeptId { get; set; }

    public DateOnly? InvDate { get; set; }

    public short? SubSegmentId { get; set; }

    public short? SegmentId { get; set; }

    public string? Type { get; set; }

    public virtual Segment? Segment { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual VMainPnr VKeyNavigation { get; set; } = null!;
}
