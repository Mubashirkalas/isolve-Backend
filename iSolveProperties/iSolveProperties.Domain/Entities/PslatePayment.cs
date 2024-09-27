using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PslatePayment
{
    public int ProjectSrno { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public int LatePaymentSrno { get; set; }

    public DateOnly? PaidDate { get; set; }

    public int? LateChargesPaid { get; set; }

    public virtual ProjectSale ProjectSale { get; set; } = null!;
}
