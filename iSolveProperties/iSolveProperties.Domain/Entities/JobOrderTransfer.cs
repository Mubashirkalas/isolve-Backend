using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class JobOrderTransfer
{
    public byte? FrmWh { get; set; }

    public byte? FrmSubsegment { get; set; }

    public byte? ToWh { get; set; }

    public byte? ToSubsegment { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public short? QtyCylinder { get; set; }

    public double? QtyM3 { get; set; }

    public double? QtyKg { get; set; }

    public double? QtyLtr { get; set; }

    public int SrNo { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;
}
