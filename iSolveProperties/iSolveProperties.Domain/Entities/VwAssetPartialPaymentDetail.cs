using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetPartialPaymentDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? FinancialYear { get; set; }

    public string? VendorCode { get; set; }

    public string? Vendor { get; set; }
}
