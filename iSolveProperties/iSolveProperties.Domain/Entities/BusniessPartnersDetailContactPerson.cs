using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BusniessPartnersDetailContactPerson
{
    public int? Sno { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? Tel { get; set; }

    public string? Cell { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public byte? CompId { get; set; }

    public string? BusinessPartnersCode { get; set; }

    public string? BpType { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
