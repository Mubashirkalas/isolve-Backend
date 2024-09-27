using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Sublet
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

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

    public string? AmountPer { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;
}
