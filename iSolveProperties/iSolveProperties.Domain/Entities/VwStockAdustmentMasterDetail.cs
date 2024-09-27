using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwStockAdustmentMasterDetail
{
    public string Srno { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SUser { get; set; }

    public short? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public short? SubSegmentId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public byte? Sno { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public byte? WareHouseNo { get; set; }

    public double? QtyInStock { get; set; }

    public string? Reason { get; set; }

    public double? AddQty { get; set; }

    public double? DeductedQty { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public string? Whname { get; set; }

    public byte Whno { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }
}
