using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InventoryList
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string Name { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public bool AutoShow { get; set; }
}
