using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWAtcnewReport
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string AtcNo { get; set; } = null!;

    public DateOnly? AtcDate { get; set; }

    public string? PartyCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? Product { get; set; }

    public string? Ownership { get; set; }

    public string? Capacity { get; set; }

    public int? CylinderQty { get; set; }

    public int? TestProcedureCode { get; set; }

    public string? Issue { get; set; }

    public double? Amount { get; set; }

    public int? TotalQty { get; set; }

    public double? TotalAmount { get; set; }

    public int? Cpqty { get; set; }

    public double? Cpamount { get; set; }

    public int? Mclqty { get; set; }

    public double? Mclamount { get; set; }

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
