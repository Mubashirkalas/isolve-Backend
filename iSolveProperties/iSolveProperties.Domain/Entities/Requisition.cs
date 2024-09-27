using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Requisition
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public string? Status { get; set; }

    public bool? Approved { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? Type { get; set; }

    public string? Department { get; set; }

    public string? DemandType { get; set; }

    public string? RequisitionAgainst { get; set; }

    public int? ProductionOrderNo { get; set; }

    public int? ProductionOrderSrno { get; set; }

    public int? FormulationCode { get; set; }

    public string? ProductionType { get; set; }

    public double? FinishGoodsQty { get; set; }
}
