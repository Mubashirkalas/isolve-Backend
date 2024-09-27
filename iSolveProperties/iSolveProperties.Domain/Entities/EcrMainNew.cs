using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EcrMainNew
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? VehicleId { get; set; }

    public string? IgpNo { get; set; }

    public DateOnly? IgpDate { get; set; }

    public string? RouteReturn { get; set; }

    public int? TotalCylinder { get; set; }

    public int? TotalOk { get; set; }

    public int? TotalSendtoTestShop { get; set; }
}
