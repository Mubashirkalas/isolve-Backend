using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Commission
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }
}
