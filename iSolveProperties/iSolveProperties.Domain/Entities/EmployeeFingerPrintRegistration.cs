﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeFingerPrintRegistration
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public int? FingerNo { get; set; }

    public string? Data { get; set; }
}
