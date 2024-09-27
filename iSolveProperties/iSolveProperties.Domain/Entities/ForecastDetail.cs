using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ForecastDetail
{
    public byte? SerialNo { get; set; }

    public byte? Sno { get; set; }

    public string? Month { get; set; }

    public int? Sales { get; set; }

    public int? Revenue { get; set; }

    public int? Leads { get; set; }
}
