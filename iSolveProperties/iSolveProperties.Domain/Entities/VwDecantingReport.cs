using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDecantingReport
{
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

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public int? DecantingNo { get; set; }

    public DateOnly? DecantingDate { get; set; }

    public string? TankNo { get; set; }

    public double? BeforeLevel { get; set; }

    public double? BeforePressure { get; set; }

    public double? BeforeKg { get; set; }

    public double? BeforeM3 { get; set; }

    public double? AfterLevel { get; set; }

    public double? AfterPressure { get; set; }

    public double? AfterKg { get; set; }

    public double? AfterM3 { get; set; }

    public double? ChartKg { get; set; }

    public double? ChartM3 { get; set; }

    public double? IgpKg { get; set; }

    public double? IgpM3 { get; set; }

    public double? DecantingKg { get; set; }

    public double? DecantingM3 { get; set; }

    public string? SubSegmentName { get; set; }

    public int? Sno { get; set; }

    public string? Igpno { get; set; }

    public string? Igpdate { get; set; }

    public string? Pono { get; set; }

    public string? Podate { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public byte? SubSegmentIdIgp { get; set; }

    public string? SubSegmentNameIgp { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? Uom { get; set; }

    public double? IssueQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }

    public string? Dcno { get; set; }

    public string? Dcdate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public byte? WarehouseNo { get; set; }

    public string? Whname { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? GasStored { get; set; }

    public double? CapacityKg { get; set; }

    public string? Location { get; set; }

    public double? BeforeLtr { get; set; }

    public double? AfterLtr { get; set; }

    public double? IgpLtr { get; set; }

    public double? DecantingLtr { get; set; }

    public double? ChartLtr { get; set; }
}
