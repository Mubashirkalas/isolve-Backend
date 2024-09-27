using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Catagory
{
    public string CatagoryCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? FYear { get; set; }

    public int? CompId { get; set; }
}
