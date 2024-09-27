using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingformReceipt
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

    public int? TotalAmount { get; set; }

    public int? Remaining { get; set; }

    public int? PaidAmount { get; set; }

    public int? MembershipFee { get; set; }

    public int? BookingAmount { get; set; }

    public virtual BookingForm? BookingForm { get; set; }

    public virtual CustomerReceipt? CustomerReceipt { get; set; }
}
