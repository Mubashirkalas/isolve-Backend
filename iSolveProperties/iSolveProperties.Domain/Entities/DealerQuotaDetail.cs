using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DealerQuotaDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public string Pid { get; set; } = null!;

    public int Amount { get; set; }

    public virtual DealerQuotum DealerQuotum { get; set; } = null!;
}
