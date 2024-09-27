using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotationBusinessPartner
{
    public byte SubSegmentNo { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string QuotationNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;
}
