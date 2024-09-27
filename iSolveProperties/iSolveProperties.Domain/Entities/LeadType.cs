using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeadType
{
    public byte? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public string? TypeName { get; set; }
}
