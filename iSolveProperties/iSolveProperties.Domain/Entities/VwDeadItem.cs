using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDeadItem
{
    public DateOnly? GrnDate { get; set; }

    public int? TotalDays { get; set; }

    public short DeadItemDay { get; set; }

    public string? ItemName { get; set; }

    public string ItemGroup { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string ItemCode { get; set; } = null!;
}
