using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwigp
{
    public double IgpNo { get; set; }

    public DateOnly? IgpDate { get; set; }

    public int? GateInNo { get; set; }

    public DateOnly? GateInDate { get; set; }

    public int? SrNo { get; set; }

    public string? Type { get; set; }

    public double? PoNo { get; set; }

    public string? ItCode { get; set; }

    public string? ItDesc { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? SupplierCode { get; set; }

    public string? Name { get; set; }

    public string? ModeofPacking { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public int? DlCode { get; set; }

    public DateOnly? DlDate { get; set; }

    public string? VehicleNo { get; set; }

    public string? DriverName { get; set; }

    public string? CellNo { get; set; }

    public int? GinNo { get; set; }

    public string? GinDate { get; set; }

    public int? ReceiveQty { get; set; }
}
