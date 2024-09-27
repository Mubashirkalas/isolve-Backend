using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ConfirmationPaymentCustomerReceipt
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public int? ReceiptNo { get; set; }

    public int? ReceiptSrno { get; set; }

    public int? Cash { get; set; }

    public int? Cheque { get; set; }

    public int? Online { get; set; }

    public int? Discount { get; set; }

    public int? OwnAmount { get; set; }

    public int? InstrumentAmount { get; set; }

    public int? MembershipFee { get; set; }

    public int? TotalAmount { get; set; }

    public int? Remaining { get; set; }

    public int? PaidAmount { get; set; }

    public string? FinancialYear { get; set; }

    public virtual ConfirmationPayment? ConfirmationPayment { get; set; }

    public virtual CustomerReceipt? CustomerReceipt { get; set; }
}
