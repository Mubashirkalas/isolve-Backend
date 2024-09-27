using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AppRightsVoucher
{
    public string? VoucherType { get; set; }

    public short? UserId { get; set; }

    public virtual AppRight? User { get; set; }
}
