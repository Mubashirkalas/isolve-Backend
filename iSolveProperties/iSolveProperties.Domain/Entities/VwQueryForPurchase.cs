﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQueryForPurchase
{
    public int SerialNo { get; set; }

    public string? Date { get; set; }

    public DateTime? OriginalDate { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Size { get; set; }

    public byte? Qty { get; set; }

    public int? Amount { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public string? Address { get; set; }

    public string? Remarks { get; set; }
}
