using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProductPricingMaster
{
    public int Srno { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string? LevelThree { get; set; }

    public string? LevelFour { get; set; }

    public string? LevelFive { get; set; }
}
