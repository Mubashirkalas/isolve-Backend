using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalesManDetail
{
    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public int? Sno { get; set; }

    public string? RouteId { get; set; }

    public virtual RouteRegistration? RouteRegistration { get; set; }

    public virtual SalesMan? SalesMan { get; set; }
}
