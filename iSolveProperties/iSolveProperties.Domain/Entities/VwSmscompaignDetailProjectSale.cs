using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSmscompaignDetailProjectSale
{
    public int? Srno { get; set; }

    public short? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public int? Sno { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public string? ClientName { get; set; }

    public string? Cnic { get; set; }

    public string? ProjectName { get; set; }

    public string? AreaTitle { get; set; }

    public DateOnly? Date { get; set; }

    public string? Contact { get; set; }
}
