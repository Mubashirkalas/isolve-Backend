using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBpRoute
{
    public string? BPCode { get; set; }

    public string? BPName { get; set; }

    public string? Addresses { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public byte? CompId { get; set; }

    public string? BpType { get; set; }
}
