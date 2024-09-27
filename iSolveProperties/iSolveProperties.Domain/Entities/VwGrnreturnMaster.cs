using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnreturnMaster
{
    public string? Bpname { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? ReturnType { get; set; }

    public int? Grnno { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Keys { get; set; }
}
