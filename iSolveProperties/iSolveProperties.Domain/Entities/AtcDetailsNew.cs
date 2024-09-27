using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AtcDetailsNew
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? AtcNo { get; set; }

    public short? Sno { get; set; }

    public string? PartyCode { get; set; }

    public string? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? Product { get; set; }

    public string? Ownership { get; set; }

    public string? Capacity { get; set; }

    public int? CylinderQty { get; set; }

    public int? TestProcedureCode { get; set; }

    public double? Amount { get; set; }

    public int? TotalQty { get; set; }

    public double? TotalAmount { get; set; }

    public int? Cpqty { get; set; }

    public double? Cpamount { get; set; }

    public int? Mclqty { get; set; }

    public double? Mclamount { get; set; }

    public string? DoNo { get; set; }

    public virtual AtcMainNew? AtcMainNew { get; set; }
}
