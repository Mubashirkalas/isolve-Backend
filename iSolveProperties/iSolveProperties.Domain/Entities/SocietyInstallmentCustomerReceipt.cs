using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SocietyInstallmentCustomerReceipt
{
    public int? Srno { get; set; }

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

    public virtual CustomerReceipt? CustomerReceipt { get; set; }

    public virtual SocietyInstallment? SocietyInstallment { get; set; }
}
