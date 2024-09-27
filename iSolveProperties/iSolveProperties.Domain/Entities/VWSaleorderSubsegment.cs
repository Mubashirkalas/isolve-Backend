using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSaleorderSubsegment
{
    public string? SaleNo { get; set; }

    public string? SalesDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BpCode { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? Status { get; set; }

    public string Srno { get; set; } = null!;
}
