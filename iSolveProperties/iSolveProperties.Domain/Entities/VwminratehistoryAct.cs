using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwminratehistoryAct
{
    public string? ItDescMin { get; set; }

    public string ItCodeMin { get; set; } = null!;

    public string? ItUnitMin { get; set; }

    public string? TrGrnnominn { get; set; }

    public decimal? Minrateact { get; set; }

    public string? Partymin { get; set; }

    public DateOnly? Grndateminn { get; set; }
}
