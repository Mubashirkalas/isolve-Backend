using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDiscountPolicyMainDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? FromDate { get; set; }

    public string? PolicyName { get; set; }

    public string? Criteria { get; set; }

    public int? Frequency { get; set; }

    public DateOnly? ToDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public bool? Status { get; set; }

    public string? DiscountTitle { get; set; }

    public string? ParentGroupName { get; set; }

    public int? Sno { get; set; }

    public string? DiscountTypeCode { get; set; }

    public string? DiscountType { get; set; }

    public string? ParentGroupCode { get; set; }

    public double? Discount { get; set; }

    public string? Remarks { get; set; }

    public string? SalesType { get; set; }

    public string? DiscountCriteria { get; set; }

    public double? RangeFrom { get; set; }

    public double? RangeTo { get; set; }

    public double? SlabDicsount { get; set; }
}
