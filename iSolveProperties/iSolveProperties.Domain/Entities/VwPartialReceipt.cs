using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartialReceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public string? DocumentNo { get; set; }

    public string? PaymentMode { get; set; }

    public int? Amount { get; set; }

    public string? AccountNo { get; set; }

    public int? SerialNo { get; set; }

    public string? BankName { get; set; }

    public string? PaymentTo { get; set; }

    public string? SalesManId { get; set; }

    public string? SalesManName { get; set; }

    public string? DocumentSrno { get; set; }

    public string? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? DealNo { get; set; }
}
