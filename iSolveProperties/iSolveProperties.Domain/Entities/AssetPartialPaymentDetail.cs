using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AssetPartialPaymentDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? FinancialYear { get; set; }

    public string? VendorCode { get; set; }

    public virtual AssetPartialPayment AssetPartialPayment { get; set; } = null!;

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;
}
