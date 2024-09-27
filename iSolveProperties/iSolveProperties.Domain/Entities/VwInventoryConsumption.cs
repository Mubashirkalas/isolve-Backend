using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInventoryConsumption
{
    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public DateOnly? Date { get; set; }

    public int? Srno { get; set; }

    public string? SubSegmentName { get; set; }

    public short? SubProjectId { get; set; }

    public int Boqqty { get; set; }

    public double? QtyIssued { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }

    public short? SubSegmentId { get; set; }
}
