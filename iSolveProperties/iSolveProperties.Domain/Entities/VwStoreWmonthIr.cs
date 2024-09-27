using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwStoreWmonthIr
{
    public string? Main { get; set; }

    public DateOnly? MDate { get; set; }

    public decimal Purchase { get; set; }

    public decimal? Issueing { get; set; }
}
