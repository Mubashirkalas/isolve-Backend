using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectSale
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Contact { get; set; }

    public string? City { get; set; }

    public string? ReferringPerson { get; set; }

    public byte? PropertyDetail { get; set; }

    public short? Area { get; set; }

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

    public string? SubSegmentName { get; set; }

    public string? Bpname { get; set; }

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

    public string? VendorName { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string? ChequeStatus { get; set; }

    public byte? BookingCategory { get; set; }

    public string? BookingType { get; set; }

    public double? DealerCommission { get; set; }

    public double? CompanyCommission { get; set; }

    public int? CustomerBankId { get; set; }

    public string? ChequeInHandSrno { get; set; }

    public string? PartyPaymentSrno { get; set; }

    public string? CustomerBankName { get; set; }

    public string? Commission { get; set; }

    public short? BlockSerialNo { get; set; }

    public short? Project { get; set; }

    public string? DealerCode { get; set; }

    public string? Dealer { get; set; }

    public string? ReferringType { get; set; }

    public string? ReferringPersonCommission { get; set; }

    public string ChequeTo { get; set; } = null!;

    public string? CompanyChequeNo { get; set; }

    public string? CompanyChequebookNo { get; set; }

    public DateOnly? CompanyChequeDate { get; set; }

    public double? Discount { get; set; }

    public string? CommissionType { get; set; }

    public string? AreaTitle { get; set; }

    public string? PropertyTitle { get; set; }

    public string? CategoryTitle { get; set; }

    public string? TypeTitle { get; set; }

    public DateOnly? AllotmentDate { get; set; }

    public string? ProjectName { get; set; }

    public double? Online { get; set; }

    public bool? InventoryPurchase { get; set; }

    public string? Cnic { get; set; }

    public string? Email { get; set; }

    public string? TeamLeader { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? ReceiptNo { get; set; }

    public string? DealNo { get; set; }

    public string? TeamLeaderName { get; set; }

    public string? UserName { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public string? ConfirmationReceiptsDelivery { get; set; }

    public string? ProjectSaleDelivery { get; set; }

    public string? ProjectSaleReceipts { get; set; }

    public string? ProjectSaleReceiptsDelivery { get; set; }

    public string? FileReceiving { get; set; }

    public string? FileDelivery { get; set; }

    public string? Confirmation { get; set; }

    public string? ConfirmationPayment { get; set; }

    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public double? TotalPriceOfProperty { get; set; }

    public string? ExtraChargesSerialNo { get; set; }

    public string? InstallmentPlanSerialNo { get; set; }

    public string? ExtraChargesTitle { get; set; }

    public string? PosessionCertificateDelivery { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? ProjectSaleNo { get; set; }

    public string? PropertyDescription { get; set; }

    public string? TransferCode1 { get; set; }

    public string? TransferCode2 { get; set; }

    public string? TransferName1 { get; set; }

    public string? TransferName2 { get; set; }

    public string? BlockName { get; set; }

    public string? PlanName { get; set; }

    public string? NextToKin { get; set; }

    public string? NextToKinContact { get; set; }

    public string? Type { get; set; }

    public string? FileNo { get; set; }

    public string? TransferCnic1 { get; set; }

    public string? TransferCnic2 { get; set; }

    public string? TransferContact1 { get; set; }

    public string? TransferContact2 { get; set; }

    public string? TransferEmail1 { get; set; }

    public string? TransferEmail2 { get; set; }

    public string? TransferCity1 { get; set; }

    public string? TransferCity2 { get; set; }

    public byte[]? SubSegmentPic { get; set; }

    public string? LateChargesPerDay { get; set; }

    public string? InstallmentType { get; set; }

    public double? RentalAmount { get; set; }

    public byte[]? Pic { get; set; }

    public string? BioMetricId { get; set; }

    public int? FingerPrintSrno { get; set; }

    public byte[]? CompanyLogo { get; set; }

    public string? StatusUpdationKey { get; set; }

    public string? CompanyName { get; set; }

    public string? Url { get; set; }

    public string? Address { get; set; }

    public string? Smscode { get; set; }

    public string? TransferNextToKin { get; set; }

    public string? TransferContact { get; set; }

    public DateOnly? CashDate { get; set; }

    public DateOnly? OnlineDate { get; set; }

    public string? MembershipNo { get; set; }

    public string? FatherName { get; set; }

    public string? NextToKinCnic { get; set; }

    public string? Relationship { get; set; }

    public string? RentalPlan { get; set; }

    public string? NextToKinAddress { get; set; }

    public string? ProjectAddress { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? TransferFatherName { get; set; }

    public string? TransferRelationship { get; set; }

    public string? TransferNextToKinAddress { get; set; }

    public string? Remarks { get; set; }

    public string? TransferNextToKinCnic { get; set; }

    public byte? Prints { get; set; }

    public string? Status { get; set; }

    public string? ProjectStatus { get; set; }

    public string? PslateChargesPerDay { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? RentalStartDate { get; set; }

    public DateOnly? RentalEndDate { get; set; }

    public string? WebLink { get; set; }

    public string? TaxStatus { get; set; }

    public int? FilerTax { get; set; }

    public int? NonFilerTax { get; set; }

    public double? SoldArea { get; set; }

    public int? AreaRate { get; set; }

    public string? PlanType { get; set; }

    public string? BookingFormNo { get; set; }

    public string? ProjectInventoryStatus { get; set; }

    public int? TokenAmount { get; set; }
}
