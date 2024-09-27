using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LatePaymentChargesDetail
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? Sno { get; set; }

    public virtual LatePaymentCharge? LatePaymentCharge { get; set; }
}
