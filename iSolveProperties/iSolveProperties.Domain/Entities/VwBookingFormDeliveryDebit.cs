using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormDeliveryDebit
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? AccountCode { get; set; }

    public int? Debit { get; set; }

    public string? Type { get; set; }

    public string? AccountName { get; set; }
}
