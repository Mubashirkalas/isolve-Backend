using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPriceList
{
    public byte CompId { get; set; }

    public short? UserId { get; set; }

    public DateOnly? Date { get; set; }

    public string? PricePlanName { get; set; }

    public DateOnly? AppliableDate { get; set; }

    public int? ProjectSerialNo { get; set; }

    public bool? Active { get; set; }

    public int SerialNo { get; set; }

    public string? ProjectName { get; set; }
}
