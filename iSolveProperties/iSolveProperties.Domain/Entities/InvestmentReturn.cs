using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InvestmentReturn
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? InvestorSrno { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? TotalInvestment { get; set; }

    public int? ProfitAccrued { get; set; }

    public int? AmountInCash { get; set; }

    public int? AmountInBank { get; set; }

    public string? AccountNo { get; set; }

    public string? Investor { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
