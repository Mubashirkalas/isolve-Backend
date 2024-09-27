using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RouteDetail
{
    public string? VehicleType { get; set; }

    public short? DriverDaily { get; set; }

    public short? LoaderDaily { get; set; }

    public short? Tolltax { get; set; }

    public string? RouteId { get; set; }

    public byte? CompId { get; set; }

    public virtual RouteRegistration? RouteRegistration { get; set; }
}
