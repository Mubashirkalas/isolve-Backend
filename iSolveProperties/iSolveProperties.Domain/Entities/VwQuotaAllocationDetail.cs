using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotaAllocationDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? AreaId { get; set; }

    public string? AreaName { get; set; }

    public byte? PropertyType { get; set; }

    public string? Property { get; set; }

    public int? FileNo { get; set; }

    public int? Amount { get; set; }

    public int? OwnAmount { get; set; }

    public int? Discount { get; set; }

    public string? Rebate { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public string? Status { get; set; }

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? DealPurchaseSrno { get; set; }

    public string? FormNo { get; set; }

    public string? DealName { get; set; }

    public short? Project { get; set; }

    public string? ProjectName { get; set; }

    public int? DpserialNo { get; set; }

    public short? SubSegmentId { get; set; }
}
