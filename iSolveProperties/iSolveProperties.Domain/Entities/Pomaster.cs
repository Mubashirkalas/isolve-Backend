using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Pomaster
{
    public int? PoNo { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? Bpcode { get; set; }

    public DateOnly? ValidityDate { get; set; }

    public string? Mop { get; set; }

    public string Keys { get; set; } = null!;

    public double? TotalAmount { get; set; }

    public string Year { get; set; } = null!;

    public short? SUer { get; set; }

    public byte CompId { get; set; }

    public string? Terms { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? DelivryDate { get; set; }

    public string? ModeofPacking { get; set; }

    public double? PoDiscountper { get; set; }

    public double? PoStaxper { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SrNo { get; set; }

    public string? Status { get; set; }

    public bool? Import { get; set; }

    public string? ForeignCurrency { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPersonEmail { get; set; }

    public string? Type { get; set; }

    public string? RequisitionNo { get; set; }

    public DateOnly? RequisitionDate { get; set; }

    public bool? Approved { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
