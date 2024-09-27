using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectInventoryDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public int? Sno { get; set; }

    public string? PropertyDescription { get; set; }

    public string? PropertyDetailsSerialNo { get; set; }

    public string? BlocksDetailsSerialNo { get; set; }

    public short? AreaSerialNo { get; set; }

    public double? CostPerProperty { get; set; }

    public string? Status { get; set; }

    public string? StatusUpdationKey { get; set; }

    public string? Transfer { get; set; }

    public string? Exchange { get; set; }

    public int? SalesPrice { get; set; }

    public string? FileUpload { get; set; } // New field for uploaded file

    public virtual ProjectInventory? ProjectInventory { get; set; }
}
