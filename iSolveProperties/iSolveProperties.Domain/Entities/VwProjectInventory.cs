using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectInventory
{
    public string SubSegmentName { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public double? Cash { get; set; }

    public string? BankId { get; set; }

    public double? AmountInBank { get; set; }

    public string? ProjectSerialNo { get; set; }

    public string? ProjectName { get; set; }

    public string? BankName { get; set; }

    public string? InventoryType { get; set; }
}
