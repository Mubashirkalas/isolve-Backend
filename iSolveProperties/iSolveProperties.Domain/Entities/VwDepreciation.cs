using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDepreciation
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? TypeId { get; set; }

    public string? SubSegmentName { get; set; }

    public byte? TimePeriod { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Type { get; set; }
}
