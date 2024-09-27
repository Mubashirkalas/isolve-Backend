using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemchart
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public string? ItemName { get; set; }
}
