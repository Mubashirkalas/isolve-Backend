using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EquipmentGroup
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItLoc { get; set; }

    public string? ItPartno { get; set; }

    public double? ItOpbal { get; set; }

    public double? ItOpagval { get; set; }

    public double? ItCbal { get; set; }

    public double? ItAvgval { get; set; }

    public bool? ItImp { get; set; }

    public string? ItPgl { get; set; }

    public string? ItCgl { get; set; }

    public string? ItExpcode { get; set; }

    public string? ItSalecode { get; set; }

    public string? ItPreturnscode { get; set; }

    public string? ItReturnscode { get; set; }

    public string? ItNotes { get; set; }

    public double? ItRoqty { get; set; }

    public double? ItCRate { get; set; }

    public DateTime? Opdate { get; set; }

    public string? SUser { get; set; }

    public string? OpeningYear { get; set; }

    public byte CompId { get; set; }

    public string? ItWorkstation { get; set; }

    public int? ItUserid { get; set; }

    public string? ItCapCode { get; set; }

    public virtual ICollection<EquipmentRegistrationMaster> EquipmentRegistrationMasters { get; set; } = new List<EquipmentRegistrationMaster>();
}
