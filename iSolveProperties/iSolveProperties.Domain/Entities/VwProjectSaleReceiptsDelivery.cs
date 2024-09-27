using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectSaleReceiptsDelivery
{
    public string SubSegmentName { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ReceiptNo { get; set; }

    public string? ClientRepresentativeName { get; set; }

    public string? ProjectSaleSrno { get; set; }

    public string? Expr1 { get; set; }

    public string? ProjectSaleNo { get; set; }
}
