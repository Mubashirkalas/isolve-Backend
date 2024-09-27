using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDomasterReturn
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

    public string? DoReturnNo { get; set; }
}
