using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFormsIssuanceDetail
{
    public int? Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? AreaId { get; set; }

    public short Sno { get; set; }

    public byte? CategoryId { get; set; }

    public string? FormNo { get; set; }

    public string? Bpcode { get; set; }

    public int? FileNo { get; set; }

    public string? Bpname { get; set; }

    public string? Property { get; set; }

    public string? AreaName { get; set; }
}
