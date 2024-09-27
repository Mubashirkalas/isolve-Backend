using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PriceList
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? UserId { get; set; }

    public DateOnly? Date { get; set; }

    public string? PricePlanName { get; set; }

    public DateOnly? AppliableDate { get; set; }

    public int? ProjectSerialNo { get; set; }

    public bool? Active { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }
}
