using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDepositedDetail
{
    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public double? CheqAmount { get; set; }

    public double? Wht153 { get; set; }

    public double? Salestax { get; set; }

    public string? DepositedIn { get; set; }

    public string? DsNo { get; set; }

    public DateOnly? DsDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public int? ReceiptNo { get; set; }

    public DateOnly? ReceiptDate { get; set; }
}
