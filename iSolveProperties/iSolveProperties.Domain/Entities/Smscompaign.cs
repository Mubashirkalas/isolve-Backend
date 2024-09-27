using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Smscompaign
{
    public int Srno { get; set; }

    public short CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? CustomerType { get; set; }

    public int? Project { get; set; }

    public string? Msg { get; set; }

    public string? TypeId { get; set; }
}
