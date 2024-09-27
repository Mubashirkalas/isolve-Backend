using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVmainPnr
{
    public string VType { get; set; } = null!;

    public DateOnly? VDate { get; set; }

    public int VNo { get; set; }

    public bool? VCancel { get; set; }

    public bool? VPost { get; set; }

    public string? VCheqNo { get; set; }

    public DateOnly? VCheqDate { get; set; }

    public string VKey { get; set; } = null!;

    public string? VUsername { get; set; }

    public DateTime? VEnterDate { get; set; }

    public string? VConfirmedBy { get; set; }

    public string? VSuperwisedBy { get; set; }

    public string? AgentCode { get; set; }

    public byte? CompId { get; set; }

    public short? VUserId { get; set; }

    public string? VWorkStation { get; set; }

    public byte? SegmentId { get; set; }

    public DateOnly? VContractDate { get; set; }

    public string? VInvNo { get; set; }

    public DateOnly? VInvDate { get; set; }

    public string? FYear { get; set; }

    public decimal? VExcRate { get; set; }

    public string? VPort { get; set; }

    public string? Vremarks { get; set; }

    public string? ModifiedUserName { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedWs { get; set; }

    public byte SubSegmentId { get; set; }

    public string? Status { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string SubSegment { get; set; } = null!;

    public string? UserName { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsReviewed { get; set; }

    public short? ReviewedById { get; set; }

    public DateTime? ReviewedDate { get; set; }

    public string? ReviewedBy { get; set; }
}
