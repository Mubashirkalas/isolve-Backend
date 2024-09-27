﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRequisitionDetail
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? UsedQty { get; set; }

    public string? Status { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public string? Remarks { get; set; }

    public string? Keys { get; set; }

    public double? BalanceQty { get; set; }

    public double? ActualQty { get; set; }
}
