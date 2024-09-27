using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempRequisition
{
    public bool? SelectCheck { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? BalQty { get; set; }

    public double? ReqQty { get; set; }

    public string? ReqNo { get; set; }

    public DateOnly? ReqDate { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public short? UserId { get; set; }
}
