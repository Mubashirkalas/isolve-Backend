using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeRegistrationAssignmentVehicle
{
    public short? SNo { get; set; }

    public string? Vehicle { get; set; }

    public string? UseType { get; set; }

    public double? FuelAllowedLtr { get; set; }

    public double? MeterReading { get; set; }

    public byte? CompId { get; set; }

    public string? SrNo { get; set; }
}
