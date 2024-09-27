using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectSale
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientCode { get; set; }

    public string? Contact { get; set; }

    public string? City { get; set; }

    public string? ProjectSaleNo { get; set; }

    public string? ReferringPerson { get; set; }

    public byte? PropertyDetail { get; set; }

    public short? Area { get; set; }

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

    public byte? BookingCategory { get; set; }

    public byte? BookingType { get; set; }

    public double? DealerCommission { get; set; }

    public double? CompanyCommission { get; set; }

    public string? ChequeInHandSrno { get; set; }

    public string? PartyPaymentSrno { get; set; }

    public string? Commission { get; set; }

    public short? BlockSerialNo { get; set; }

    public short? Project { get; set; }

    public string? DealerCode { get; set; }

    public string? ReferringType { get; set; }

    public string? ReferringPersonCommission { get; set; }

    public string ChequeTo { get; set; } = null!;

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

    public string? ProjectSaleDelivery { get; set; }

    public string? ProjectSaleReceipts { get; set; }

    public string? ProjectSaleReceiptsDelivery { get; set; }

    public string? FileReceiving { get; set; }

    public string? FileDelivery { get; set; }

    public string? Confirmation { get; set; }

    public string? ConfirmationPayment { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public string? ConfirmationReceiptsDelivery { get; set; }

    public double? TotalPriceOfProperty { get; set; }

    public string? ExtraChargesSerialNo { get; set; }

    public string? InstallmentPlanSerialNo { get; set; }

    public string? PosessionCertificateDelivery { get; set; }

    public string? TransferCnic1 { get; set; }

    public string? TransferCnic2 { get; set; }

    public string? TransferContact1 { get; set; }

    public string? TransferContact2 { get; set; }

    public string? TransferEmail1 { get; set; }

    public string? TransferEmail2 { get; set; }

    public string? TransferCity1 { get; set; }

    public string? TransferCity2 { get; set; }

    public string? TransferCode1 { get; set; }

    public string? TransferCode2 { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? NextToKin { get; set; }

    public string? NextToKinContact { get; set; }

    public string? FileNo { get; set; }

    public string? Type { get; set; }

    public string? InstallmentType { get; set; }

    public byte[]? Pic { get; set; }

    public double? RentalAmount { get; set; }

    public string? BioMetricId { get; set; }

    public int? FingerPrintSrno { get; set; }

    public string? MembershipNo { get; set; }

    public string? TransferNextToKin { get; set; }

    public string? TransferContact { get; set; }

    public DateOnly? CashDate { get; set; }

    public DateOnly? OnlineDate { get; set; }

    public string? FatherName { get; set; }

    public string? NextToKinCnic { get; set; }

    public string? Relationship { get; set; }

    public string? NextToKinAddress { get; set; }

    public string? RentalPlan { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? TransferFatherName { get; set; }

    public string? TransferRelationship { get; set; }

    public string? TransferNextToKinAddress { get; set; }

    public string? TransferNextToKinCnic { get; set; }

    public string? Remarks { get; set; }

    public string? ProjectStatus { get; set; }

    public string? PslateChargesPerDay { get; set; }

    public DateOnly? RentalStartDate { get; set; }

    public DateOnly? RentalEndDate { get; set; }

    public double? SoldArea { get; set; }

    public int? AreaRate { get; set; }

    public string? PlanType { get; set; }

    public string? BookingFormNo { get; set; }

    public string? ProjectInventoryStatus { get; set; }

    public int? TokenAmount { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual BlocksDetail? BlocksDetail { get; set; }

    public virtual BookingCategoryDetail? BookingCategoryDetail { get; set; }

    public virtual BookingTypeDetail? BookingTypeDetail { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain1 { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMainNavigation { get; set; }

    public virtual ICollection<BuyBack> BuyBacks { get; set; } = new List<BuyBack>();

    public virtual ICollection<LatePaymentCharge> LatePaymentCharges { get; set; } = new List<LatePaymentCharge>();

    public virtual User? Muser { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual ICollection<ProjectReschedule> ProjectReschedules { get; set; } = new List<ProjectReschedule>();

    public virtual ICollection<ProjectReversal> ProjectReversals { get; set; } = new List<ProjectReversal>();

    public virtual ICollection<ProjectTransfer> ProjectTransfers { get; set; } = new List<ProjectTransfer>();

    public virtual PropertyDetail? PropertyDetailNavigation { get; set; }

    public virtual ICollection<PslatePayment> PslatePayments { get; set; } = new List<PslatePayment>();

    public virtual ICollection<RentalStructure> RentalStructures { get; set; } = new List<RentalStructure>();

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
