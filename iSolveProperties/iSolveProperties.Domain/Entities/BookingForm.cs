using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingForm
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? City { get; set; }

    public string? BookingFormNo { get; set; }

    public string? ReferringPerson { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Area { get; set; }

    public int? CustomerBankId { get; set; }

    public string? ChequeNo { get; set; }

    public double? PercentageOfPayment { get; set; }

    public double? Amount { get; set; }

    public double? TotalAmount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public double? DealerChequeAdjustment { get; set; }

    public double? DealerCashAdjustment { get; set; }

    public double? DealerComissionAdjustment { get; set; }

    public double? CompanyChequeAdjustment { get; set; }

    public double? CompanyCashAdjustment { get; set; }

    public double? CompanyComissionAdjustment { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? VendorCode { get; set; }

    public int? BankId { get; set; }

    public string? AccountNo { get; set; }

    public string? ChequeStatus { get; set; }

    public string? BookingCategory { get; set; }

    public string? BookingType { get; set; }

    public double? DealerCommission { get; set; }

    public double? CompanyCommission { get; set; }

    public string? ChequeInHandSrno { get; set; }

    public string? PartyPaymentSrno { get; set; }

    public string? Commission { get; set; }

    public string? BlockSerialNo { get; set; }

    public string? Project { get; set; }

    public string? DealerCode { get; set; }

    public string? ReferringType { get; set; }

    public string? ReferringPersonCommission { get; set; }

    public string? ChequeTo { get; set; }

    public string? CompanyChequeNo { get; set; }

    public string? CompanyChequebookNo { get; set; }

    public DateOnly? CompanyChequeDate { get; set; }

    public double? Discount { get; set; }

    public string? CommissionType { get; set; }

    public DateOnly? AllotmentDate { get; set; }

    public double? Online { get; set; }

    public string? Cnic { get; set; }

    public string? Email { get; set; }

    public string? TeamLeader { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? ReceiptNo { get; set; }

    public string? DealNo { get; set; }

    public string? BookingFormDelivery { get; set; }

    public string? BookingReceipts { get; set; }

    public string? BookingReceiptsDelivery { get; set; }

    public string? FileReceiving { get; set; }

    public string? FileDelivery { get; set; }

    public string? Confirmation { get; set; }

    public string? ConfirmationPayment { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public string? ConfirmationReceiptsDelivery { get; set; }

    public string? CustomerReceiptSrno { get; set; }

    public string? ReceiptType { get; set; }

    public string? ReceiptClearingStatus { get; set; }

    public DateOnly? ReceiptClearingDate { get; set; }

    public int? ReceiptClearingUserId { get; set; }

    public string? AccountNumber { get; set; }

    public bool? Approved { get; set; }

    public DateOnly? ApprovedDate { get; set; }

    public int? ApprovedByUserId { get; set; }

    public double? OwnAmount { get; set; }

    public string? DealPurchaseSrno { get; set; }

    public string? Instrument { get; set; }

    public string? SocietyInstallment { get; set; }

    public string? SocietyInstallmentPayment { get; set; }

    public string? InstallmentReceipt { get; set; }

    public string? InstallmentReceiptDelivery { get; set; }

    public int? SocietySerialNo { get; set; }

    public int? InstrumentAmount { get; set; }

    public string? Customer { get; set; }

    public int? FileNo { get; set; }

    public int? FilePurchaseAmount { get; set; }

    public string? ManagementRemarks { get; set; }

    public int? MembershipFee { get; set; }

    public string? QuotaParty { get; set; }

    public string? Submit { get; set; }

    public string? Msno { get; set; }

    public virtual ICollection<BookingFormIssue> BookingFormIssues { get; set; } = new List<BookingFormIssue>();

    public virtual ICollection<BookingFormReceiving> BookingFormReceivings { get; set; } = new List<BookingFormReceiving>();

    public virtual ICollection<BookingReceipt> BookingReceiptsNavigation { get; set; } = new List<BookingReceipt>();

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMainNavigation { get; set; }

    public virtual ICollection<ConfirmationPayment> ConfirmationPayments { get; set; } = new List<ConfirmationPayment>();

    public virtual ICollection<ConfirmationReceipt> ConfirmationReceipts { get; set; } = new List<ConfirmationReceipt>();

    public virtual ICollection<ConfirmationReceiptsDelivery> ConfirmationReceiptsDeliveries { get; set; } = new List<ConfirmationReceiptsDelivery>();

    public virtual ICollection<FileDeliveryConfirmation> FileDeliveryConfirmations { get; set; } = new List<FileDeliveryConfirmation>();

    public virtual ICollection<FileReceiving> FileReceivings { get; set; } = new List<FileReceiving>();

    public virtual ICollection<InstallmentReceiptDelivery> InstallmentReceiptDeliveries { get; set; } = new List<InstallmentReceiptDelivery>();

    public virtual ICollection<InstallmentReceipt> InstallmentReceipts { get; set; } = new List<InstallmentReceipt>();

    public virtual ICollection<ReceiptsDelivery> ReceiptsDeliveries { get; set; } = new List<ReceiptsDelivery>();

    public virtual ICollection<SocietyInstallment> SocietyInstallments { get; set; } = new List<SocietyInstallment>();
}
