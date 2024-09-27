using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInstrumentInOut
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public DateOnly? Date { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? Type { get; set; }

    public string? SocietyCode { get; set; }

    public string? SocietyName { get; set; }

    public string? InvestorCode { get; set; }

    public string? InvestorName { get; set; }

    public string? InstrumentNo { get; set; }

    public string Remarks { get; set; } = null!;

    public string? DealName { get; set; }

    public int? DealNo { get; set; }

    public int? Amount { get; set; }

    public int? CashAmount { get; set; }

    public int? BankAmount { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }
}
