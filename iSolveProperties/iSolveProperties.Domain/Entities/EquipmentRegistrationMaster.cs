using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EquipmentRegistrationMaster
{
    public string ItemGroupCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public byte CompId { get; set; }

    public string? ItemName { get; set; }

    public string? StatusOfEquipment { get; set; }

    public string? Barcode { get; set; }

    public short? Subsegment { get; set; }

    public int? Code { get; set; }

    public string? Model { get; set; }

    public string? Make { get; set; }

    public DateOnly? OperationDate { get; set; }

    public string? ItemConsumption { get; set; }

    public string? TechLabourCharges { get; set; }

    public string? OutsourceServicesCost { get; set; }

    public double? OtherCosts { get; set; }

    public virtual EquipmentGroup EquipmentGroup { get; set; } = null!;
}
