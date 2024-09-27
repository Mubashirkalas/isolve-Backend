using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BusinessPartnersDetailAddress
{
    public int? Sno { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? GlYear { get; set; }

    public byte? CompId { get; set; }

    public string? BusinessPartnersCode { get; set; }

    public string? RouteName { get; set; }

    public string? ContactPerson { get; set; }

    public string? CellNo { get; set; }

    public string? BpType { get; set; }

    public string? RouteId { get; set; }

    public bool? IsDefault { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
