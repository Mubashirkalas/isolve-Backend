using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIgpmasterDetail
{
    public int SerialNo { get; set; }

    public string? IgpDate { get; set; }

    public short? Posno { get; set; }

    public string PoDate { get; set; } = null!;

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Rate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string GroupCode { get; set; } = null!;

    public string? GroupName { get; set; }

    public string Bpcode { get; set; } = null!;

    public string BusinessPartnersName { get; set; } = null!;

    public byte? SubSegmentCode { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public short SubSegmentIgp { get; set; }

    public string? FinancialYear { get; set; }

    public byte? CompId { get; set; }

    public string? Status { get; set; }

    public string DlDate { get; set; } = null!;

    public string DlCode { get; set; } = null!;

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public double? ReceiveQty { get; set; }

    public string VehicleNo { get; set; } = null!;

    public string DriverName { get; set; } = null!;

    public string CellNo { get; set; } = null!;

    public string? Type { get; set; }

    public string GinNo { get; set; } = null!;

    public string GinDate { get; set; } = null!;

    public int? Srno { get; set; }

    public string SubSegmentNameIgp { get; set; } = null!;

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Phoneno { get; set; }

    public string Keys { get; set; } = null!;

    public double OrderedQty { get; set; }

    public DateOnly? IgpDate1 { get; set; }

    public string Barcode { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string? StatusMain { get; set; }

    public string? UserName { get; set; }

    public string Ownership { get; set; } = null!;

    public int? Pono { get; set; }
}
