using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ContractInventory
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public short? BlockSerialNo { get; set; }

    public int? InventorySerialNo { get; set; }

    public byte? Qty { get; set; }

    public virtual Contract Contract { get; set; } = null!;
}
