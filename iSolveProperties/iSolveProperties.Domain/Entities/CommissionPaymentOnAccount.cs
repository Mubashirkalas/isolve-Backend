using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CommissionPaymentOnAccount
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public int? CommissionDue { get; set; }

    public int? ComissionPaid { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual CommissionPayment? CommissionPayment { get; set; }
}
