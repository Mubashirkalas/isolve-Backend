using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRequisition
{
    public string? PiNo { get; set; }

    public string? PiDate1 { get; set; }

    public string? CcCode { get; set; }

    public string? ReqType { get; set; }

    public double? PiQty { get; set; }

    public string? PiReqdate { get; set; }

    public short? Srno { get; set; }

    public string? Remarks { get; set; }

    public string? SubSegmentName { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string Keys { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public string? CcDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public string? SrNo1 { get; set; }

    public string? Uom { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public double? ActualQty { get; set; }

    public double? Qty { get; set; }

    public string? Status { get; set; }

    public DateOnly? PiDate { get; set; }
}
