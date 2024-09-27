﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRebateDefinition
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public string? PlanName { get; set; }

    public string? VendorRebate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ProjectRegistrationName { get; set; }
}
