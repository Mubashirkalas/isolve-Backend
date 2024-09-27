using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EquipmentRegistrationDetailPart
{
    public string? ItemGroupCode { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public byte? Sno { get; set; }

    public string? Description { get; set; }

    public string? MakeSupplier { get; set; }

    public int? Qty { get; set; }

    public string? Remarks { get; set; }

    public virtual EquipmentRegistrationMaster? EquipmentRegistrationMaster { get; set; }
}
