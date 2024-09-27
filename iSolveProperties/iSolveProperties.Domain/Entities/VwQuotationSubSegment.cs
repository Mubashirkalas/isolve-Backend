using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotationSubSegment
{
    public string SrNo { get; set; } = null!;

    public string BusinessPartnersCode { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string? Attention { get; set; }

    public string? Designation { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? ContactNo { get; set; }

    public string? Terms { get; set; }

    public string? ComplimentaryClose { get; set; }

    public string? Subject { get; set; }

    public DateOnly? Date { get; set; }

    public string? RefNo { get; set; }

    public string? SerialNo { get; set; }

    public string? Status { get; set; }

    public byte SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;
}
