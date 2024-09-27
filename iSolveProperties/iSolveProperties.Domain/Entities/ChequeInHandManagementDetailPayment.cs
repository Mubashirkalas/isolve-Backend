using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ChequeInHandManagementDetailPayment
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? Sno { get; set; }

    public byte? BankId { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? Amount { get; set; }

    public string? Action { get; set; }

    public byte? BankIdentity { get; set; }

    public string? Remarks { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountType { get; set; }

    public string? ChequeNumber { get; set; }

    public virtual PartyPaymentMain PartyPaymentMain { get; set; } = null!;
}
