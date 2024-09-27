using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotaAllocationModifiedDetail
{
    public short? Sno { get; set; }

    public int? FileNo { get; set; }

    public short? AreaId { get; set; }

    public string? AreaName { get; set; }

    public byte? PropertyType { get; set; }

    public string? Property { get; set; }

    public int? Amount { get; set; }

    public int? PownAmount { get; set; }

    public int? Pdiscount { get; set; }

    public string? Prebate { get; set; }

    public int? OwnAmount { get; set; }

    public int? Discount { get; set; }

    public string? Rebate { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public string? Pbpcode { get; set; }

    public string? Pbpname { get; set; }

    public string? FormNo { get; set; }

    public string? Status { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public DateOnly? Date { get; set; }

    public string? ProjectName { get; set; }

    public string? DealName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? SerialNo { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }
}
