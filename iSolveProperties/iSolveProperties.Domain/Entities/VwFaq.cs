using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFaq
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }
}
