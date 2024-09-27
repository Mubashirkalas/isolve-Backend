using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartySecurity
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public short? Sno { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Spc { get; set; }

    public double? Total { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? BpType { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string? AcNo { get; set; }

    public string? CheqSlipNo { get; set; }

    public DateOnly? CheqSlipDate { get; set; }

    public double? CheqAmount { get; set; }
}
