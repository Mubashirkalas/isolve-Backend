using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDetailPnr
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

    public string? GlDesc { get; set; }

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

    public string? ModifiedUserName { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedWs { get; set; }

    public string? ModifiedUserName1 { get; set; }

    public DateTime? VEnterDate { get; set; }

    public string? VUsername { get; set; }

    public bool? VPost { get; set; }

    public string? Type { get; set; }

    public string? AccountName { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? AccountTitle { get; set; }

    public string? Tel1 { get; set; }

    public string? Cellno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? BankName { get; set; }

    public byte[]? SubSegmentPic { get; set; }

    public string? Status { get; set; }

    public bool? IsReviewed { get; set; }

    public short? ReviewedById { get; set; }

    public DateTime? ReviewedDate { get; set; }

    public string? ReviewedBy { get; set; }

    public short? SubProjectId { get; set; }

    public string? SubProjectName { get; set; }

    public bool? GlvoucherApprovedWaterMark { get; set; }

    public bool? Glrestriction { get; set; }

    public short? PostedById { get; set; }

    public DateTime? PostedDate { get; set; }

    public string? PostedBy { get; set; }

    public bool? ClientOfficeCopyOnGlprint { get; set; }
}
