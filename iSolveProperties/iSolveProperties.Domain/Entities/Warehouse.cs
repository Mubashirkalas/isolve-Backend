﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Warehouse
{
    public short Whno { get; set; }

    public string? Whname { get; set; }

    public string? Whlocation { get; set; }

    public string? Whaddress { get; set; }

    public string? Whincharge { get; set; }

    public string? Whinchargecontactno { get; set; }

    public string? Whstotagecapacity { get; set; }

    public byte CompId { get; set; }
}
