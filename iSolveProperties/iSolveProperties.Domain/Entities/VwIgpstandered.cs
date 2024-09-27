using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIgpstandered
{
    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public int? SerialNo { get; set; }

    public string? FinancialYear { get; set; }

    public int? Pono { get; set; }

    public DateOnly? Podate { get; set; }

    public string? VehicleNo { get; set; }

    public string? BuiltyNo { get; set; }

    public string? DriverName { get; set; }

    public string? DriverCellNo { get; set; }

    public string? CarriageType { get; set; }

    public string? Bpcode { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ItemName { get; set; }

    public double? OrderedQty { get; set; }

    public double? ReceiveQty { get; set; }

    public short? Ppqty { get; set; }

    public short? JuteQty { get; set; }

    public string? GateInNo { get; set; }

    public DateOnly? GateInDate { get; set; }

    public string? DeliveryChallanNo { get; set; }

    public DateOnly? DeliveryChallanDate { get; set; }

    public short? Sno { get; set; }

    public byte? CompId { get; set; }

    public string? SuserName { get; set; }

    public string? Bpname { get; set; }

    public string? GroupCode { get; set; }

    public short? Posno { get; set; }

    public string? Pokey { get; set; }

    public string? ItemCode { get; set; }
}
