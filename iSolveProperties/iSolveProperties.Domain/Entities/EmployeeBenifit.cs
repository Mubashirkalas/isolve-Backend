using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeBenifit
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Type { get; set; }

    public string? RuleLevel { get; set; }

    public string? DebitAccount { get; set; }

    public string? CreditAccount { get; set; }

    public string? Criteria { get; set; }

    public double? MinRange { get; set; }

    public double? MaxRange { get; set; }
}
