using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempWarehouse
{
    public byte? WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public short? UserId { get; set; }
}
