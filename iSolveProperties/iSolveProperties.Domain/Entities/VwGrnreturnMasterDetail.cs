using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnreturnMasterDetail
{
    public string? Bpname { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int Srno { get; set; }

    public int? SerialNo { get; set; }

    public byte CompId { get; set; }

    public double? Qty { get; set; }

    public string? Uom { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? BatchNo { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public byte? Whno { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? Whname { get; set; }

    public int? Grnno { get; set; }

    public string? ReturnType { get; set; }

    public DateOnly? Date { get; set; }

    public short? Sno { get; set; }

    public string? GroupName { get; set; }

    public double? ToBeDeliveredQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }
}
