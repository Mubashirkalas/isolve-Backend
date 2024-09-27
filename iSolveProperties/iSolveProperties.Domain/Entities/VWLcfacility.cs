using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWLcfacility
{
    public short Sno { get; set; }

    public byte CompId { get; set; }

    public string AccountNumber { get; set; } = null!;
}
