using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwServiceRegistration
{
    public string GlDesc { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? ServiceType { get; set; }

    public string? ServiceLine { get; set; }

    public double? ServiceCharges { get; set; }

    public string GlCode { get; set; } = null!;
}
