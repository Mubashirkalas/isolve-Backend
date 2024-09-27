using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeResgistrationDesignation
{
    public short? SNo { get; set; }

    public string? Designation { get; set; }

    public string? Segment { get; set; }

    public string? Type { get; set; }

    public string? GlDesc { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public byte? CompId { get; set; }

    public string? SrNo { get; set; }

    public string? Name { get; set; }

    public short? SubSegmentId { get; set; }
}
