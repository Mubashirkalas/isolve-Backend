using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PrMaster
{
    public int PrNo { get; set; }

    public string GlCode { get; set; } = null!;

    public DateOnly? PrDate { get; set; }

    public int? Ogp { get; set; }

    public DateOnly? GpDate { get; set; }

    public int? DNoteNo { get; set; }

    public DateOnly? DNoteDate { get; set; }

    public int? VNo { get; set; }

    public DateOnly? VDate { get; set; }

    public string? VPost { get; set; }
}
