﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDealPurchaseDetailActual
{
    public double Amount { get; set; }

    public int FileNo { get; set; }

    public int Sno { get; set; }

    public string Status { get; set; } = null!;

    public short AreaId { get; set; }

    public byte PropertyType { get; set; }

    public string FormNo { get; set; } = null!;

    public string? Area { get; set; }

    public string? Property { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }
}
