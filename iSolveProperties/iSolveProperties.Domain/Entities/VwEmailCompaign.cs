using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmailCompaign
{
    public string? Type { get; set; }

    public string? SubSegmentName { get; set; }

    public string? ProjectName { get; set; }

    public int? SerialNo { get; set; }

    public string? Keys { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? CustomerType { get; set; }

    public short? Expr1 { get; set; }

    public string? Msg { get; set; }

    public string? TypeId { get; set; }

    public string? Subject { get; set; }
}
