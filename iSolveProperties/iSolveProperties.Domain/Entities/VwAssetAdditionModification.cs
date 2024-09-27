using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetAdditionModification
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? SubSegmentName { get; set; }

    public string? BankName { get; set; }

    public string? AccountNo { get; set; }

    public int? AmountInBank { get; set; }

    public int? AmountInCash { get; set; }

    public string? UserName { get; set; }
}
