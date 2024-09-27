﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DeliveryOrderCashSale
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? DoNo { get; set; }

    public byte? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Capacity { get; set; }

    public int? Quantity { get; set; }

    public double? UnitRate { get; set; }

    public double? Value { get; set; }

    public string? BpCode { get; set; }

    public virtual DeliveryOrderMaster? DeliveryOrderMaster { get; set; }
}
