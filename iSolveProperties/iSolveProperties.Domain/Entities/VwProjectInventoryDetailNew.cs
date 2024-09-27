using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectInventoryDetailNew
{
    public string? SerialNo { get; set; }

    public string? PropertyDescription { get; set; }

    public string? BlockName { get; set; }

    public string? AreaName { get; set; }

    public double? CostPerProperty { get; set; }

    public string? InventoryType { get; set; }

    public double? RemainingArea { get; set; }

    public string? Status { get; set; }

    public string? ProjectSerialNo { get; set; }

    public byte? CompId { get; set; }

    public string? StatusUpdationKey { get; set; }

    public string? PropertyDetailsTitle { get; set; }

    public string? PropertyDetailsSerialNo { get; set; }

    public string? BlocksDetailsSerialNo { get; set; }

    public short? AreaSerialNo { get; set; }

    public int? SalesPrice { get; set; }

    public string? Srno { get; set; }
  
    public string? FinancialYear { get; set; }
    public string? ProjectName { get; set; }
    public int? SNo { get; set; }

    public string? FileUpload { get; set; } // New field for uploaded file

}
