using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingConfirmationLetter
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int Srno { get; set; }

    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? ProjectId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? AreaTitle { get; set; }

    public string? ProjectName { get; set; }

    public string? PropertyDescription { get; set; }

    public string? FatherName { get; set; }

    public byte? BookingCategory { get; set; }

    public string? MembershipNo { get; set; }

    public DateOnly? Expr1 { get; set; }

    public string? Contact { get; set; }

    public string? Cnic { get; set; }

    public string? BlockName { get; set; }

    public double? TotalAmount { get; set; }

    public double? Amount { get; set; }

    public string? Bpname { get; set; }

    public double? DealerCashAdjustment { get; set; }

    public double? DealerChequeAdjustment { get; set; }

    public double? Online { get; set; }

    public string? BankName { get; set; }

    public short? Project { get; set; }

    public string? ProjectSaleNo { get; set; }
}
