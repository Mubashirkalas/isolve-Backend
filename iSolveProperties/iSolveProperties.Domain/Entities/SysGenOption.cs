using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SysGenOption
{
    public decimal Saletaxpercent { get; set; }

    public decimal Qtytobagpercent { get; set; }

    public decimal RoundFig { get; set; }

    public bool AddStatus { get; set; }
}
