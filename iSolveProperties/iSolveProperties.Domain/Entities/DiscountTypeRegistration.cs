using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountTypeRegistration
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? DiscountTitle { get; set; }

    public string? DiscountType { get; set; }
}
