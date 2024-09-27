using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Exm
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Opening { get; set; }

    public decimal? Opvalue { get; set; }

    public decimal Receipt { get; set; }

    public decimal Receiptv { get; set; }

    public decimal Issue { get; set; }

    public decimal Issuev { get; set; }

    public decimal Sale { get; set; }

    public decimal Salev { get; set; }
}
