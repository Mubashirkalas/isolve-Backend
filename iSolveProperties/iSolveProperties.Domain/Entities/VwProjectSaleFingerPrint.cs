using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectSaleFingerPrint
{
    public string? ClientName { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? FingerNo { get; set; }

    public string? Data { get; set; }

    public string? FormName { get; set; }
}
