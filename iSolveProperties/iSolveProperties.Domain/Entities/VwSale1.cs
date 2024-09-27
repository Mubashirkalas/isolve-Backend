using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSale1
{
    public string VKey { get; set; } = null!;

    public int SNo { get; set; }

    public string? VType { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? GlCode { get; set; }

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

    public string? CName { get; set; }

    public string Description { get; set; } = null!;

    public string GlDesc { get; set; } = null!;

    public byte[]? Pic { get; set; }

    public string VType1 { get; set; } = null!;

    public string? VWorkStation { get; set; }

    public DateOnly? VContractDate { get; set; }

    public string? VInvNo { get; set; }

    public DateOnly? VInvDate { get; set; }

    public decimal? VExcRate { get; set; }

    public string? VPort { get; set; }

    public string? Vremarks { get; set; }

    public int? Monthno { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte? SegmentId { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public byte SubSegmentId { get; set; }

    public string? UserName { get; set; }

    public short? VUserId { get; set; }

    public string? FYear { get; set; }

    public double? NetBalance { get; set; }

    public string? SegmentName { get; set; }
}
