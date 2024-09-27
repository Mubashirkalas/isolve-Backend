﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeBenifitDetail
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

    public string? EmployeeName { get; set; }

    public string? SubSegmentName { get; set; }

    public string? DesignationTitle { get; set; }
}
