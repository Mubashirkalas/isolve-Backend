using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwReceiptMasterDetail
{
    public string? GroupCode { get; set; }

    public double? Qty { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxPayable { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? CreditMemoNo { get; set; }

    public DateOnly? CreditMemoDate { get; set; }

    public double? CreditMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public double? AmountReceived { get; set; }

    public string? Ipno { get; set; }

    public DateOnly? Ipdate { get; set; }

    public bool? SelectIpno { get; set; }

    public double? AdvanceIncomeTax { get; set; }

    public double? _15SalesTax { get; set; }

    public short? Ipsrno { get; set; }

    public double? AmountToBeReceived { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string Srno { get; set; } = null!;

    public string? ReceiptNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public bool? Bptype { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte CompId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? CreationDate { get; set; }

    public short? UserId { get; set; }

    public string? ModifiedUserName { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ChequeNo { get; set; }

    public bool? ReceivedonAccount { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? AccountNo { get; set; }

    public string? Status { get; set; }

    public double? ChequeAmount { get; set; }

    public string? Bpcode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? BankName { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? AccountTitle { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? TelephoneNo { get; set; }

    public string? Itemname { get; set; }

    public string? RegionId { get; set; }

    public string? RegionName { get; set; }

    public string? PartyType { get; set; }

    public string? RecoveryAgent { get; set; }

    public double? InvoiceValue { get; set; }

    public double? Rate { get; set; }

    public string? Uom { get; set; }

    public double? FreightPerUnit { get; set; }

    public string? Brand { get; set; }

    public string? Category { get; set; }
}
