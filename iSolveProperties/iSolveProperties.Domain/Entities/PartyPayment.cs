using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyPayment
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? AdvanceBalance { get; set; }

    public double? InvoiceBalance { get; set; }

    public double? SecurityBalance { get; set; }

    public double? ApaccrualBalance { get; set; }

    public double? NetBalance { get; set; }

    public string? Bptype { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string? AccountNumber { get; set; }

    public string? SlipNo { get; set; }

    public DateOnly? SlipDate { get; set; }

    public double? Amount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }
}
