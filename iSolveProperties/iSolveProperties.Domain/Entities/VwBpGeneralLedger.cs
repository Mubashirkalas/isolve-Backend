using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBpGeneralLedger
{
    public double ObpartyVoucherDetail { get; set; }

    public double Coaob { get; set; }

    public string BusinessPartnersCode { get; set; } = null!;

    public string? VType { get; set; }

    public int? SNo { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? CheqNo { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string? BusinessPartnersName { get; set; }

    public DateOnly? CheqDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? VGlyear { get; set; }

    public bool? VPost { get; set; }

    public string? Status { get; set; }

    public double? CreditLimitAmount { get; set; }
}
