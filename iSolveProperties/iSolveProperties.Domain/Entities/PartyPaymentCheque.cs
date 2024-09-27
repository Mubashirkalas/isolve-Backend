using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyPaymentCheque
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte? Sno { get; set; }

    public string? PaidVia { get; set; }

    public string? Docno { get; set; }

    public byte? BankId { get; set; }

    public string? AccountNumber { get; set; }

    public string? ChequeNumber { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? Amount { get; set; }

    public string? Action { get; set; }

    public string? Remarks { get; set; }

    public virtual PartyPayment PartyPayment { get; set; } = null!;
}
