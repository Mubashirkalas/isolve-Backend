using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InstrumentInOut
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? DealNo { get; set; }

    public short? ProjectId { get; set; }

    public string? Type { get; set; }

    public string? SocietyCode { get; set; }

    public string? InvestorCode { get; set; }

    public string? InstrumentNo { get; set; }

    public int? Amount { get; set; }

    public string Remarks { get; set; } = null!;

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? CashAmount { get; set; }

    public int? BankAmount { get; set; }

    public string? AccountNo { get; set; }

    public virtual DealPurchase? DealPurchase { get; set; }
}
