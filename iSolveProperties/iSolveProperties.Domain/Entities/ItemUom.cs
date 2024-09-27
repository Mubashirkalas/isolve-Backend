using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ItemUom
{
    public string? Uom { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public byte? Listindex { get; set; }

    public string? ItemGroup { get; set; }

    public string? Uomdescription { get; set; }

    public bool? IsPrimary { get; set; }

    public virtual ItemMaster? ItemMaster { get; set; }
}
