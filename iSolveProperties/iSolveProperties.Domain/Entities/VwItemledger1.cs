using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemledger1
{
    public int? Grnno { get; set; }

    public string? Type { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentNameMain { get; set; } = null!;

    public int? Srno { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public short? SubSegmentCode { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double PurchaseQty { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal TotalValue { get; set; }

    public int? Igpno { get; set; }

    public string? IgpDate { get; set; }

    public int? Pono { get; set; }

    public string? PoDate { get; set; }

    public string? Dcno { get; set; }

    public string? DcDate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public short? WarehouseNo { get; set; }

    public string? Whname { get; set; }

    public short? Sno { get; set; }

    public string? CreationDate { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public double IssueQty { get; set; }

    public DateOnly? Grndate { get; set; }

    public decimal TotalSinValue { get; set; }

    public string? DeptCode { get; set; }

    public string? VehicleId { get; set; }

    public DateOnly? GrnDate1 { get; set; }

    public long SerialNo { get; set; }

    public long DetailSno { get; set; }

    public string? WarehouseFromToName { get; set; }
}
