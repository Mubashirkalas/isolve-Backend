using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectInventory
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ProjectSerialNo { get; set; }

    public double? Cash { get; set; }

    public string? BankId { get; set; }

    public string? PaymentMode { get; set; }

    public double? AmountInBank { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? InventoryType { get; set; }

    public virtual ICollection<DealerQuotum> DealerQuota { get; set; } = new List<DealerQuotum>();
}
