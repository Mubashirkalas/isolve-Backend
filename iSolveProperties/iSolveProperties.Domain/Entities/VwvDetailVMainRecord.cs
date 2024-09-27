using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwvDetailVMainRecord
{
    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? BillDate { get; set; }

    public double? Qty1 { get; set; }

    public string? Unit1 { get; set; }

    public double? Qty2 { get; set; }

    public string? Unit2 { get; set; }

    public string? InvNo { get; set; }

    public string? CountNo { get; set; }

    public byte? CompId { get; set; }

    public string? VGlyear { get; set; }

    public int? DeptId { get; set; }

    public DateOnly? InvDate { get; set; }

    public DateOnly? CheqDate { get; set; }

    public string? CheqNo { get; set; }

    public string? GlCode { get; set; }

    public DateOnly? VDate { get; set; }

    public string? VType { get; set; }

    public int SNo { get; set; }

    public string VKey { get; set; } = null!;

    public string VType1 { get; set; } = null!;

    public DateOnly? Expr1 { get; set; }

    public int VNo { get; set; }

    public bool? VCancel { get; set; }

    public bool? VPost { get; set; }

    public string? VCheqNo { get; set; }

    public DateOnly? VCheqDate { get; set; }

    public string Expr2 { get; set; } = null!;

    public string? VUsername { get; set; }

    public DateOnly? VEnterDate { get; set; }

    public string? VConfirmedBy { get; set; }

    public string? VSuperwisedBy { get; set; }

    public byte? Company { get; set; }

    public string? AgentCode { get; set; }

    public short? VUserId { get; set; }

    public string? VWorkStation { get; set; }

    public DateOnly? VContractDate { get; set; }

    public string? VInvNo { get; set; }

    public DateOnly? VInvDate { get; set; }

    public decimal? VExcRate { get; set; }

    public string? VPort { get; set; }

    public string? Vremarks { get; set; }

    public int? Monthno { get; set; }

    public string GlDesc { get; set; } = null!;

    public byte[]? Pic { get; set; }

    public string GlYear { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string SubSegmentName { get; set; } = null!;

    public string? SubSegmentPic { get; set; }
}
