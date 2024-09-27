using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class GrnMaster
{
    public int GrnNo { get; set; }

    public string GlCode { get; set; } = null!;

    public DateOnly? GrnDate { get; set; }

    public int? GatePassno { get; set; }

    public DateOnly? GpDate { get; set; }

    public int? BillNo { get; set; }

    public DateOnly? BillDate { get; set; }

    public DateOnly? VoucherDate { get; set; }
}
