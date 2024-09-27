using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDomaster
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public DateOnly? DoDate { get; set; }

    public string? Type { get; set; }

    public string DoNo { get; set; } = null!;

    public string? CommissionAgent { get; set; }

    public string? GlDesc { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public bool? DirectArrangement { get; set; }

    public string? ContactNo { get; set; }

    public string? BuiltyNo { get; set; }

    public DateOnly? BuiltyDate { get; set; }

    public double? BuiltyAmount { get; set; }

    public string? DeliveryArrangement { get; set; }

    public string? PaidBy { get; set; }

    public string? PhoneNo { get; set; }

    public string? Particulars { get; set; }
}
