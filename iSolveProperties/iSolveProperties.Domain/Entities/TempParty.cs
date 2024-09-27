using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempParty
{
    public string? BpCode { get; set; }

    public short? UserId { get; set; }

    public byte? CompId { get; set; }
}
