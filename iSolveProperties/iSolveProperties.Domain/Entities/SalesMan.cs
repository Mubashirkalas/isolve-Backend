using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalesMan
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Name { get; set; }
}
