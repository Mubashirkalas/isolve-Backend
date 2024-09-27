using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempGrn
{
    public string? DocNo { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? DocType { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public double? TotalValue { get; set; }

    public short? UserId { get; set; }

    public double? SalexTax { get; set; }

    public double? Value { get; set; }
}
