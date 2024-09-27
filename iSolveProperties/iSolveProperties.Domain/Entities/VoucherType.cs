using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VoucherType
{
    public string VoucherType1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? GlCode { get; set; }

    public string? CodeType { get; set; }

    public string? Catagory { get; set; }

    public short? VId { get; set; }

    public short? SeriaNo { get; set; }
}
