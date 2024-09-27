using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCommissionDetail
{
    public string? Bpname { get; set; }

    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public int? Sno { get; set; }

    public string? Bpcode { get; set; }

    public double? OverseaseCommercialCommission { get; set; }

    public double? LocalCommercialCommission { get; set; }

    public double? OverseaseResidentialCommission { get; set; }

    public double? LocalResidentialCommission { get; set; }
}
