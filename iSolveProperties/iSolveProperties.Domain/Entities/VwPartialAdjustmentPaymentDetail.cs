using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartialAdjustmentPaymentDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? ClearingSrno { get; set; }

    public string? ChequesSrno { get; set; }

    public string? Bpcode { get; set; }

    public byte? DishonouredChequeBankId { get; set; }

    public string? DishonouredChequeNo { get; set; }

    public DateOnly? DishonouredChequeDate { get; set; }

    public double? DishonouredChequeAmount { get; set; }

    public double? RemainingAmount { get; set; }

    public string? AdjustmentMode { get; set; }

    public byte? BankId { get; set; }

    public string? AccountNo { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? Narration { get; set; }

    public double? Amount { get; set; }

    public double? Balance { get; set; }

    public string? Bpname { get; set; }

    public string? DishonouredChequeBankName { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }
}
