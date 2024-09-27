using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationAssignmentVehicle
{
    public byte? CompId { get; set; }

    public int? SrNo { get; set; }

    public short? SNo { get; set; }

    public string? Vehicle { get; set; }

    public string? UseType { get; set; }

    public double? FuelAllowedLtr { get; set; }

    public double? MeterReading { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }
}
