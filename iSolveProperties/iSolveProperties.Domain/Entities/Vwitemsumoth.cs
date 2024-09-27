using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwitemsumoth
{
    public string? ItCode { get; set; }

    public decimal? Opening { get; set; }

    public decimal? Opvalue { get; set; }

    public decimal Cqty { get; set; }

    public decimal Cvalue { get; set; }

    public decimal Rec { get; set; }

    public decimal Rvalue { get; set; }

    public decimal Ivalue { get; set; }

    public decimal Issue { get; set; }
}
