using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotationMasterDetail
{
    public string SrNo { get; set; } = null!;

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? Attention { get; set; }

    public string? Designation { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? ContactNo { get; set; }

    public string? Terms { get; set; }

    public string? ComplimentaryClose { get; set; }

    public string? Subject { get; set; }

    public DateOnly? Date { get; set; }

    public string? RefNo { get; set; }

    public string? SerialNo { get; set; }

    public byte SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte? SNo { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? Specification { get; set; }

    public string? Purity { get; set; }

    public string? Uom { get; set; }

    public double? Rpu { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public double? Qty { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string? UserName { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Expr1 { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public double? Discount { get; set; }
}
