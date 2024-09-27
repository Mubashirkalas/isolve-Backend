using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWAtc
{
    public string Keys { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public int? AtcNo { get; set; }

    public DateOnly? AtcDate { get; set; }

    public string? SubSegmentName { get; set; }

    public int? Sno { get; set; }

    public string? PartyCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public int? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? CylinderNo { get; set; }

    public string? Capacity { get; set; }

    public string? Ownership { get; set; }

    public string? Gasfilledin { get; set; }

    public int? TestProcedureCode { get; set; }

    public string? Issue { get; set; }

    public double? Amount { get; set; }

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
