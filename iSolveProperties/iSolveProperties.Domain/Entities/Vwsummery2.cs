using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwsummery2
{
    public string? ItCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItPartno { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Opening { get; set; }

    public decimal? Rece { get; set; }

    public decimal? Issue { get; set; }

    public decimal? Opvalue { get; set; }

    public decimal? Recev { get; set; }

    public decimal? Issuev { get; set; }
}
