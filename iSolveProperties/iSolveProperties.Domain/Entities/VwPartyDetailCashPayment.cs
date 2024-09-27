using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartyDetailCashPayment
{
    public string? BusinessPartnersName { get; set; }

    public string? Vtype { get; set; }

    public int? VNo { get; set; }

    public DateOnly? VDate { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public byte? CompId { get; set; }

    public string? VGlyear { get; set; }

    public byte? SubSegmentId { get; set; }

    public byte? SegmentId { get; set; }

    public string? BpCode { get; set; }

    public DateTime? VEnterDate { get; set; }

    public short? VUserId { get; set; }

    public string? VWorkStation { get; set; }

    public string? ModifiedUserName { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? VUsername { get; set; }

    public string? ModifiedWs { get; set; }

    public string? UserName { get; set; }

    public string? ModifiedUser { get; set; }

    public string? Vkey { get; set; }
}
