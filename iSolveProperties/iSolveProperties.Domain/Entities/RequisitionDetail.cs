using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RequisitionDetail
{
    public string? ItemCode { get; set; }

    public double? PiQty { get; set; }

    public DateOnly? PiReqdate { get; set; }

    public string? Keys { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public string? Remarks { get; set; }

    public short? Srno { get; set; }

    public string? ItemGroup { get; set; }

    public string? Status { get; set; }

    public string? Uom { get; set; }

    public double? ActualQty { get; set; }

    public double? Qty { get; set; }

    public virtual RequisitionMaster? KeysNavigation { get; set; }
}
