using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesGroupReturn
{
    public double? ReturnValue { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public byte? CompId { get; set; }

    public DateOnly? SireturnDate { get; set; }
}
