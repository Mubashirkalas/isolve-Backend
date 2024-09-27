using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSublet
{
    public string SubSegmentName { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Bpname { get; set; }

    public string? Project { get; set; }

    public byte CompId1 { get; set; }

    public short SubSegmentId { get; set; }

    public short? ProjectId { get; set; }

    public string? Bpcode { get; set; }

    public string? UnitDetail { get; set; }

    public double? TotalSqft { get; set; }

    public double? RatePerSqft { get; set; }

    public double? TotalAmount { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public string? Fine { get; set; }

    public int? FineAmount { get; set; }

    public int? WarrantyAmountToBeWithHeld { get; set; }

    public short SerialNo { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int Srno { get; set; }

    public string? AmountPer { get; set; }
}
