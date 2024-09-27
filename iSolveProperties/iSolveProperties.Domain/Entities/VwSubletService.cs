using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSubletService
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int Srno { get; set; }

    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public short? ProjectId { get; set; }

    public string? Project { get; set; }

    public string? AmountPer { get; set; }

    public double? TotalSqft { get; set; }

    public double? RatePerSqft { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public double? TotalAmount { get; set; }

    public string? Fine { get; set; }

    public int? FineAmount { get; set; }

    public int? WarrantyAmountToBeWithHeld { get; set; }

    public string? Name { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public short? ServicesId { get; set; }
}
