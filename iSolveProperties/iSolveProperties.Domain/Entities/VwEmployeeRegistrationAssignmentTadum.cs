using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeRegistrationAssignmentTadum
{
    public short? SNo { get; set; }

    public string? Description { get; set; }

    public double? Amount { get; set; }

    public string? Remarks { get; set; }

    public byte? CompId { get; set; }

    public string? SrNo { get; set; }
}
