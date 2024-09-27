using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCommissionPaymentOnAccount
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public int? CommissionDue { get; set; }

    public int? ComissionPaid { get; set; }
}
