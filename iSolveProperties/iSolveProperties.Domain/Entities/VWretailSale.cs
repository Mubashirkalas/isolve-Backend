using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWretailSale
{
    public string SubSegmentName { get; set; } = null!;

    public short? Subsgment { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public string? SerialNo { get; set; }

    public string? SrNo { get; set; }

    public DateOnly? Date { get; set; }
}
