using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FilePurchasingDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? FileNo { get; set; }

    public string? BookingFormNo { get; set; }

    public string? Category { get; set; }

    public string? Type { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Area { get; set; }

    public double? Price { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public int? BookingFormSrno { get; set; }

    public short? ProjectId { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? Cnic { get; set; }

    public short? BlockTypeId { get; set; }

    public bool? Visible { get; set; }

    public int? Booking { get; set; }

    public int? Confirmation { get; set; }

    public int? Installment { get; set; }

    public int? Membership { get; set; }

    public int? Profit { get; set; }

    public string? PlotDetail { get; set; }

    public int? TotalDealPrice { get; set; }

    public int? Gpafee { get; set; }

    public int? UrgentFee { get; set; }

    public int? Spafee { get; set; }

    public int? TrasferFee { get; set; }

    public int? DocumentFee { get; set; }

    public int? StampExpense { get; set; }

    public int? TotalFees { get; set; }

    public string? FileStatus { get; set; }

    public virtual FilePurchasing FilePurchasing { get; set; } = null!;
}
