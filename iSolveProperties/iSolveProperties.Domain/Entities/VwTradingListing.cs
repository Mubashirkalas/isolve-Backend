using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTradingListing
{
    public int SerialNo { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public byte? BookingTypeId { get; set; }

    public string? BookingType { get; set; }

    public string? SizeId { get; set; }

    public string SizeName { get; set; } = null!;

    public string? PhoneNo { get; set; }

    public string? CustomerName { get; set; }

    public byte? Qty { get; set; }

    public int? Amount { get; set; }

    public string? TradingType { get; set; }

    public string? FileNo { get; set; }

    public short? BlockId { get; set; }

    public string? Status { get; set; }

    public short? UserId { get; set; }

    public string? UserName { get; set; }

    public string? BlockName { get; set; }

    public bool? Viewed { get; set; }

    public string? DeviceId { get; set; }

    public short? PropertyDetailId { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Address { get; set; }

    public string? Remarks { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? CustomerType { get; set; }

    public string? HoldByUsername { get; set; }

    public int? HoldDateTime { get; set; }

    public byte? HoldHours { get; set; }

    public string? Sector { get; set; }

    public string? StreetNo { get; set; }

    public string? PlotNo { get; set; }

    public short? PropertyKsp { get; set; }

    public string? Bedrooms { get; set; }

    public string? ApartmentType { get; set; }

    public string? PropertyKspname { get; set; }

    public byte? CompId { get; set; }

    public DateOnly? Date { get; set; }

    public string? CompanyName { get; set; }
}
