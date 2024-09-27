using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetDisposal
{
    public string? BankName { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public int? SerialNo { get; set; }

    public string? AccountNo { get; set; }

    public string? SubSegmentName { get; set; }

    public int Srno { get; set; }

    public string? PaymentMode { get; set; }

    public int? AmountInCash { get; set; }

    public int? AmountInBank { get; set; }
}
