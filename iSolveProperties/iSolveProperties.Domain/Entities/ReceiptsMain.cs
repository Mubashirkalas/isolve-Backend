using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ReceiptsMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public bool? Bptype { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? SuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public short? MuserId { get; set; }

    public DateTime? McreationDate { get; set; }

    public bool? OnAccount { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? ChequeAmount { get; set; }

    public string? AccountNo { get; set; }

    public string? Status { get; set; }

    public string? Bpcode { get; set; }

    public string? RecoveryAgent { get; set; }
}
