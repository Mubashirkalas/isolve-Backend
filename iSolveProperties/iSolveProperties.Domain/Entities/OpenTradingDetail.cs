using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class OpenTradingDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? FilePurchasingSrno { get; set; }

    public string? FileNo { get; set; }

    public string? BookingFormNo { get; set; }

    public byte? Category { get; set; }

    public string? Type { get; set; }

    public byte? PropertyDetail { get; set; }

    public short? Area { get; set; }

    public double? PurchasePrice { get; set; }

    public double? SalesPrice { get; set; }

    public double? Difference { get; set; }

    public string? Remarks { get; set; }

    public string? BookingFormSrno { get; set; }

    public short? ProjectId { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual BookingCategoryDetail? BookingCategoryDetail { get; set; }

    public virtual OpenTrading OpenTrading { get; set; } = null!;

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual PropertyDetail? PropertyDetailNavigation { get; set; }
}
