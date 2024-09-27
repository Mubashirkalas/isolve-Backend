using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankClearingMain
{
    public string? BankName { get; set; }

    public byte BankId { get; set; }

    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? AcNo { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string? SubSegmentIds { get; set; }

    public double? Wht { get; set; }

    public string? AccountTitle { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? Address { get; set; }

    public double? BankCharges { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Type { get; set; }
}
