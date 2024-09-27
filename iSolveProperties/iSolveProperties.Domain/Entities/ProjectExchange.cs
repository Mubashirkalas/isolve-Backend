using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectExchange
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public double? Amount { get; set; }

    public string? ClientCode { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankId { get; set; }

    public string? Keys { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public double? TotalPaid { get; set; }

    public byte[]? Pic { get; set; }

    public string? BioMetricId { get; set; }

    public int? FingerPrintSrno { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
