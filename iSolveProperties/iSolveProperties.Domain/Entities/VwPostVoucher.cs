using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPostVoucher
{
    public string VType { get; set; } = null!;

    public DateOnly? VDate { get; set; }

    public int VNo { get; set; }

    public bool? VPost { get; set; }

    public string VKey { get; set; } = null!;
}
