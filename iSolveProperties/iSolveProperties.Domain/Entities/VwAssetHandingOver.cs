using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetHandingOver
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public short SuserId { get; set; }

    public string SuserName { get; set; } = null!;

    public string SworkStation { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string EmployeeSrno { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public string? Type { get; set; }
}
