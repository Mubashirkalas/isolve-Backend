using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EquipmentCategory
{
    public string? CategoryCode { get; set; }

    public string? Description { get; set; }

    public int CompId { get; set; }
}
