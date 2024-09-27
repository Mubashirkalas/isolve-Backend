using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWEcrmanagementCylinderWise
{
    public string Keys { get; set; } = null!;

    public int Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public int? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? VehicleId { get; set; }

    public double? IgpNo { get; set; }

    public DateOnly? IgpDate { get; set; }

    public string? RouteReturn { get; set; }

    public string? PartyCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? CylinderNo { get; set; }

    public string? Gasfilledin { get; set; }

    public string? Capacity { get; set; }

    public string? Ownership { get; set; }

    public bool? Status { get; set; }

    public int? Ok { get; set; }

    public string? SendToTestShop { get; set; }

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

    public string? Gp { get; set; }

    public string? ReferenceNo { get; set; }
}
