using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPriceListDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? AreaSerialNo { get; set; }

    public byte? CategorySerialNo { get; set; }

    public byte? PropertyDetailSerialNo { get; set; }

    public byte? BookingTypeSerialNo { get; set; }

    public short? BlockSerialNo { get; set; }

    public int? TotalPrice { get; set; }

    public int? BookingAmount { get; set; }

    public int? ConfirmationAmount { get; set; }

    public string? AreaName { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Category { get; set; }

    public string? BlockName { get; set; }

    public string? BookingType { get; set; }
}
