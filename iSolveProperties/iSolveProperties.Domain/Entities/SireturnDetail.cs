using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SireturnDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubsegmentId { get; set; }

    public string? SireturnNo { get; set; }

    public string? SrnoSi { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? BarCode { get; set; }

    public string? Uom { get; set; }

    public int? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public int? ReturnQty { get; set; }

    public double? ReturnValue { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }

    public virtual SireturnMaster? SireturnMaster { get; set; }
}
