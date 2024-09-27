using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EquipmentRegistrationDetailRoutine
{
    public string? ItemGroupCode { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public byte? Sno { get; set; }

    public byte? TaskCode { get; set; }

    public string? Description { get; set; }

    public string? Interval { get; set; }

    public string? Priority { get; set; }

    public int? Value { get; set; }

    public string? TolerenceLevel { get; set; }

    public string? AssignedUser { get; set; }

    public string? Remarks { get; set; }

    public virtual EquipmentRegistrationMaster? EquipmentRegistrationMaster { get; set; }
}
