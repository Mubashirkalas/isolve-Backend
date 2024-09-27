using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationJobDescription
{
    public byte? CompId { get; set; }

    public int? SrNo { get; set; }

    public short? SNo { get; set; }

    public string? JobDescription { get; set; }

    public string? Type { get; set; }

    public string? ReportTo { get; set; }

    public string? Remarks { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }
}
