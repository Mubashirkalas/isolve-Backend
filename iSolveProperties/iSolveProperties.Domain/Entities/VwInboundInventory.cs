using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInboundInventory
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string? FinancialYear { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? InvestorCode { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public string? MworkStation { get; set; }

    public int? MuserId { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Investor { get; set; }
}
