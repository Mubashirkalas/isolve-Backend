﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class WarehouseTransferNew
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Type { get; set; }

    public string? VehicleNo { get; set; }

    public string? DriverName { get; set; }

    public string? DriverPhoneNo { get; set; }

    public double? TransportationCharges { get; set; }

    public double? OtherOverheads { get; set; }

    public string? WarehouseFrom { get; set; }

    public string? WarehouseTo { get; set; }

    public string? Status { get; set; }

    public string? Keys { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? WarehouseFromSubSegmentId { get; set; }

    public string? WarehouseToSubSegmentId { get; set; }

    public string? DepartmentId { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedUserId { get; set; }

    public virtual User? Muser { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
