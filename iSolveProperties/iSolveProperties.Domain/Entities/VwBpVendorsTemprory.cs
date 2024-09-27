using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBpVendorsTemprory
{
    public int? SNo { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? ContactPerson { get; set; }

    public string? CellNo { get; set; }

    public string? BusinessPartnersName { get; set; }

    public byte CompId { get; set; }

    public string? Designation { get; set; }

    public string? PartyType { get; set; }

    public string BusinessPartnersCode { get; set; } = null!;

    public string BpType { get; set; } = null!;
}
