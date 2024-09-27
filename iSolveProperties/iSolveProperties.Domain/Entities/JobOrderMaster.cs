using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class JobOrderMaster
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? JobOrderNo { get; set; }

    public DateOnly? JobOrderDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? Type { get; set; }

    public string? RouteId { get; set; }

    public string? VehicleNo { get; set; }

    public double? DriverDailyCharges { get; set; }

    public double? LoaderDailyCharges { get; set; }

    public double? TotalCharges { get; set; }

    public string? Status { get; set; }

    public short? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? Username { get; set; }

    public DateTime? CreationDate { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public string? ModifiedUsername { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
