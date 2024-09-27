using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankClearing1
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }

    public string? Type { get; set; }
}
