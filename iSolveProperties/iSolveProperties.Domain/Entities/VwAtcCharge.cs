using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAtcCharge
{
    public int SNo { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public string? VType { get; set; }

    public double? Credit { get; set; }

    public string? PartyType { get; set; }
}
