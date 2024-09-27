using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeBenifitDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? DesignationCode { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? Provision { get; set; }

    public string? ProvisionFrequency { get; set; }

    public double? EmployeerContribution { get; set; }

    public double? EmployeeContribution { get; set; }

    public virtual EmployeeBenifit EmployeeBenifit { get; set; } = null!;
}
