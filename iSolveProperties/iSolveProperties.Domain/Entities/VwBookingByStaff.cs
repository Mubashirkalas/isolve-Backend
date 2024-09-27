using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingByStaff
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? BookingFormNo { get; set; }

    public string? Cnic { get; set; }

    public string? PaymentMode { get; set; }

    public DateOnly? ConfirmationDate { get; set; }

    public string? UserName { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? ProjectName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? City { get; set; }

    public string? ReferringPerson { get; set; }

    public string? Area { get; set; }

    public string? PropertyDetail { get; set; }

    public string? ChequeNo { get; set; }

    public double? PercentageOfPayment { get; set; }

    public double? Amount { get; set; }

    public double? TotalAmount { get; set; }

    public string? Project { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public string? ConfirmationReceiptsDelivery { get; set; }

    public string? BookingFormDelivery { get; set; }

    public string? BookingReceipts { get; set; }

    public string? BookingReceiptsDelivery { get; set; }

    public string? FileReceiving { get; set; }

    public string? FileDelivery { get; set; }

    public string? Confirmation { get; set; }

    public short? SuserId { get; set; }

    public string? AreaTitle { get; set; }

    public string? Commission { get; set; }

    public string? ChequeTo { get; set; }

    public bool? InventoryPurchase { get; set; }

    public double? Discount { get; set; }

    public double? DealerChequeAdjustment { get; set; }

    public double? DealerCashAdjustment { get; set; }

    public double? DealerComissionAdjustment { get; set; }

    public string? VendorCode { get; set; }

    public double? DealerCommission { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public int? ApprovedByUserId { get; set; }

    public DateOnly? ApprovedDate { get; set; }

    public bool? Approved { get; set; }

    public byte? SegmentId { get; set; }

    public string? AccountNumber { get; set; }

    public int? ReceiptClearingUserId { get; set; }

    public DateOnly? ReceiptClearingDate { get; set; }

    public string? ReceiptClearingStatus { get; set; }

    public string? FileName { get; set; }

    public double? OwnAmount { get; set; }

    public string? FileType { get; set; }

    public string? DealPurchaseSrno { get; set; }

    public string? Instrument { get; set; }

    public string? DealName { get; set; }

    public string? SocietyInstallment { get; set; }

    public string? SocietyInstallmentPayment { get; set; }

    public string? Bpname { get; set; }

    public string? PropertyTitle { get; set; }

    public string? CategoryTitle { get; set; }

    public string? TypeTitle { get; set; }

    public string? Dealer { get; set; }

    public double? Payment { get; set; }

    public string? VendorName { get; set; }

    public string? FileNo { get; set; }

    public string? BlockSerialNo { get; set; }

    public string? BookingCategory { get; set; }

    public string? BookingType { get; set; }

    public DateOnly? ReceiptReceivedDate { get; set; }

    public DateOnly? ReceiptsDate { get; set; }

    public DateOnly? ReceiptsDeliveryDeliveredDate { get; set; }

    public string? ReceiptsDeliveryRemarks { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? ModeOfPayment { get; set; }

    public DateOnly? ConfirmationReceiptsDeliveryDate { get; set; }

    public DateOnly? FileReceivedDate { get; set; }

    public DateOnly? FileDate { get; set; }

    public DateOnly? FileDeliveryConfirmationDeliveredDate { get; set; }

    public string? FileDeliveryConfirmationRemarks { get; set; }

    public string? InstallmentReceipt { get; set; }

    public string? InstallmentReceiptDelivery { get; set; }

    public DateOnly? InstallmentReceiptDeliveryDeliveredDate { get; set; }

    public string? InstallmentReceiptDeliveryRemarks { get; set; }

    public DateOnly? ConfirmationReceiptDate { get; set; }

    public DateOnly? ConfirmationReceiptReceiptDate { get; set; }

    public string? ConfirmationReceiptRemarks { get; set; }

    public DateOnly? InstallmentReceiptReceiptReceivedDate { get; set; }

    public DateOnly? InstallmentReceiptReceiptDate { get; set; }

    public string? ReferringPersonCommission { get; set; }

    public string? TeamLeaderName { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string? CustomerBankName { get; set; }

    public string? ReferringType { get; set; }

    public double? Online { get; set; }

    public string Status { get; set; } = null!;

    public string? ReceiptType { get; set; }

    public int? InstrumentAmount { get; set; }

    public string? Customer { get; set; }

    public string? CustomerNames { get; set; }

    public int? FilePurchaseAmount { get; set; }

    public double? FileAmount { get; set; }

    public string? PlanName { get; set; }

    public string? ManagementRemarks { get; set; }

    public int? MembershipFee { get; set; }

    public string? MembershipNo { get; set; }

    public string? MembershipNoS { get; set; }

    public string? Submit { get; set; }

    public string? EmployeeName { get; set; }

    public string? Office { get; set; }
}
