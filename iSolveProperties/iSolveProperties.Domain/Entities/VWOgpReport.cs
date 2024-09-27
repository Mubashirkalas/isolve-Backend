using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWOgpReport
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? OgpNo { get; set; }

    public DateOnly? OgpDate { get; set; }

    public string? DoNo { get; set; }

    public DateOnly? DoDate { get; set; }

    public string? VehicleId { get; set; }

    public string? Name { get; set; }

    public double? CylinderQyt { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public double? MeterOut { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }
}
