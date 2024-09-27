using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRequisitionReport
{
    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Type { get; set; }

    public string? Department { get; set; }

    public string? DepartmentName { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? UsedQty { get; set; }

    public string? Expr1 { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public string? Remarks { get; set; }

    public byte CompId { get; set; }

    public int Srno { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? Keys { get; set; }

    public bool? Approved { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? UserName { get; set; }

    public double? BalanceQty { get; set; }

    public double? ActualQty { get; set; }
}
