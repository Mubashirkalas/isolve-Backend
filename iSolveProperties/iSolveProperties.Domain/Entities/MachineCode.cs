﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class MachineCode
{
    public string? MchCode { get; set; }

    public string? MchDesc { get; set; }

    public string? MchNotes { get; set; }

    public string? SUser { get; set; }

    public DateTime? Opdate { get; set; }

    public int? CompId { get; set; }
}
