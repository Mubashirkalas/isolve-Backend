using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class NewUserRightsWarehouse
{
    public byte? WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public byte? CompId { get; set; }

    public short? Userid { get; set; }

    public byte? ListIndex { get; set; }
}
