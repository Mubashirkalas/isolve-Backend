using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcfacilityMain
{
    public short Sno { get; set; }

    public string AccountNumber { get; set; } = null!;

    public byte CompId { get; set; }
}
