﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingformCredit
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? AccountCode { get; set; }

    public int? Credit { get; set; }

    public string? Type { get; set; }
}
