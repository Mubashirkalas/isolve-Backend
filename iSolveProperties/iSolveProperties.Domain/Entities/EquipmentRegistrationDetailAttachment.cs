using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EquipmentRegistrationDetailAttachment
{
    public string? ItemGroupCode { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public byte? Sno { get; set; }

    public byte[]? UploadFile { get; set; }

    public string? Remarks { get; set; }

    public virtual EquipmentRegistrationMaster? EquipmentRegistrationMaster { get; set; }
}
