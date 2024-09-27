using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class MegaAccountConfiguration
{
    public string SerialNo { get; set; } = null!;

    public int CompId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
