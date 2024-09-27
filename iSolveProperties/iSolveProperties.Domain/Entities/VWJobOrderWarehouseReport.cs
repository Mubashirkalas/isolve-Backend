using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWJobOrderWarehouseReport
{
    public byte? Sno { get; set; }

    public byte? FWarehouseCode { get; set; }

    public string? FWarehouseName { get; set; }

    public byte? FWarehouseSubSegmentCode { get; set; }

    public string? FWarehouseSubSegmentName { get; set; }

    public byte? TWarehouseCode { get; set; }

    public string? TWarehouseName { get; set; }

    public byte? TWarehouseSubSegmentCode { get; set; }

    public string? TWarehouseSubSegmentName { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public int? CylindersQty { get; set; }

    public double? M3Qty { get; set; }

    public double? KgQty { get; set; }

    public double? LtrQty { get; set; }

    public string? Status { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? JobOrderNo { get; set; }

    public DateOnly? JobOrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }
}
