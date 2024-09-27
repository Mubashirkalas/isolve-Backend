using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFilePurchasingDetail
{
    public string? CategoryTitle { get; set; }

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

    public string? TypeTitle { get; set; }

    public string? AreaTitle { get; set; }

    public string? PropertyTitle { get; set; }

    public string? SerialNo { get; set; }

    public double? Cash { get; set; }

    public double? Bank { get; set; }

    public string? AccountNo { get; set; }

    public double? Total { get; set; }

    public string? Bpname { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double? Commision { get; set; }

    public string? ReferingPersonName { get; set; }

    public string? ProjectName { get; set; }

    public string? UserName { get; set; }

    public DateOnly? Date { get; set; }

    public short? ProjectId { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? Cnic { get; set; }

    public string? BlockType { get; set; }

    public short? BlockTypeId { get; set; }

    public byte? SubSegmentId { get; set; }

    public bool? Visible { get; set; }

    public string? RemarksMain { get; set; }

    public int? Booking { get; set; }

    public int? Confirmation { get; set; }

    public int? Installment { get; set; }

    public int? Membership { get; set; }

    public int? Profit { get; set; }

    public string? Bpcode { get; set; }

    public int? BankId { get; set; }

    public string? ReferingPersonCode { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

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
}
