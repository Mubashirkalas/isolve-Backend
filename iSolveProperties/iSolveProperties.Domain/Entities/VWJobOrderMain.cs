using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWJobOrderMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? JobOrderNo { get; set; }

    public DateOnly? JobOrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? RouteId { get; set; }

    public string? VehicleNo { get; set; }

    public double? DriverDailyCharges { get; set; }

    public double? LoaderDailyCharges { get; set; }

    public double? TotalCharges { get; set; }

    public string? Type { get; set; }
}
