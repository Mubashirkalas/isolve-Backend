using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class QuotaAllocationModifiedDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public int? FileNo { get; set; }

    public int? OwnAmount { get; set; }

    public int? Discount { get; set; }

    public string? Bpcode { get; set; }

    public string? Rebate { get; set; }

    public short? AreaId { get; set; }

    public byte? PropertyType { get; set; }

    public int? Amount { get; set; }

    public int? PownAmount { get; set; }

    public int? Pdiscount { get; set; }

    public string? Prebate { get; set; }

    public string? Status { get; set; }

    public string? Pbpcode { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual BookingCategoryDetail? BookingCategoryDetail { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual DealPurchaseDetail? FileNoNavigation { get; set; }

    public virtual QuotaAllocationModified QuotaAllocationModified { get; set; } = null!;
}
