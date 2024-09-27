using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CommissionDetail
{
    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public int? Sno { get; set; }

    public string? Bpcode { get; set; }

    public double? OverseaseCommercialCommission { get; set; }

    public double? LocalCommercialCommission { get; set; }

    public double? OverseaseResidentialCommission { get; set; }

    public double? LocalResidentialCommission { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual Commission? Commission { get; set; }
}
