﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingFormDeliveryDebit
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? AccountCode { get; set; }

    public int? Debit { get; set; }

    public string? Type { get; set; }

    public string? FinancialYear { get; set; }

    public virtual BookingFormDelivery? BookingFormDelivery { get; set; }
}
