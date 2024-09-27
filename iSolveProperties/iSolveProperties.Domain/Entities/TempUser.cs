using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempUser
{
    public short? AlluserId { get; set; }

    public string? UserName { get; set; }

    public short? UserId { get; set; }
}
