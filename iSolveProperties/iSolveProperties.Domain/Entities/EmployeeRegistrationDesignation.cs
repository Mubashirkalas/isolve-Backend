using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationDesignation
{
    public byte? CompId { get; set; }

    public int? SrNo { get; set; }

    public short? SNo { get; set; }

    public string? Designation { get; set; }

    public string? Segment { get; set; }

    public string? Type { get; set; }

    public DateOnly? StartDate { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }
}
