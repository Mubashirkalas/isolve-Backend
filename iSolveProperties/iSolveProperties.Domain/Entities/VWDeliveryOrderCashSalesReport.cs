using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWDeliveryOrderCashSalesReport
{
    public string FYear { get; set; } = null!;

    public byte CompId { get; set; }

    public string Srno { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public DateOnly? DoDate { get; set; }

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

    public string? Type { get; set; }

    public string DoNo { get; set; } = null!;

    public byte? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Capacity { get; set; }

    public int? Quantity { get; set; }

    public double? UnitRate { get; set; }

    public double? Value { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }
}
