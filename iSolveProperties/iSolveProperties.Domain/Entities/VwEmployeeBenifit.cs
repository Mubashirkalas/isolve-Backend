using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeBenifit
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

    public string DebitAccountTitle { get; set; } = null!;

    public string CreditAccountTitle { get; set; } = null!;
}
