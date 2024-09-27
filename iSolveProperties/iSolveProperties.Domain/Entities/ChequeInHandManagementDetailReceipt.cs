using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ChequeInHandManagementDetailReceipt
{
    public string? Srno { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public byte? Sno { get; set; }

    public byte? BankId { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? Amount { get; set; }

    public string? Action { get; set; }

    public byte? BankIdentity { get; set; }

    public string? Remarks { get; set; }

    public string? AccountNo { get; set; }

    public string? Status { get; set; }

    public string? ReceiptNo { get; set; }

    public virtual ChequeInHandManagementMain? ChequeInHandManagementMain { get; set; }
}
