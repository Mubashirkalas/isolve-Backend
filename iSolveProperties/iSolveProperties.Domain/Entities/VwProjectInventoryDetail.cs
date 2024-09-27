using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectInventoryDetail
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

    public string? BlockName { get; set; }

    public string? AreaName { get; set; }

    public string? PropertyDetailsTitle { get; set; }

    public string? Status { get; set; }

    public double? CostPerProperty { get; set; }

    public string? StatusUpdationKey { get; set; }

    public DateOnly? Date { get; set; }

    public double? Cash { get; set; }

    public string? BankId { get; set; }

    public double? AmountInBank { get; set; }

    public string? ProjectSerialNo { get; set; }

    public string? ProjectName { get; set; }

    public string? BankName { get; set; }

    public string? SerialNo { get; set; }

    public int? SalesPrice { get; set; }

    public string? FileUpload { get; set; } // New field for uploaded file
}
