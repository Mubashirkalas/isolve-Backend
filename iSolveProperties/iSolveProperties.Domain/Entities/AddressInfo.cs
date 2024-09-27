using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AddressInfo
{
    public string PCode { get; set; } = null!;

    public string? PName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Country { get; set; }

    public string? Fax { get; set; }

    public string Ntn { get; set; } = null!;

    public string Tax { get; set; } = null!;

    public string? Terms { get; set; }

    public string? CName { get; set; }

    public string? CPhone { get; set; }

    public string? CEmail { get; set; }

    public int? CompId { get; set; }

    public string? GlYear { get; set; }

    public string? AdPaymentTerms { get; set; }
}
