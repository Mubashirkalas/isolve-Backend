using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Contract
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public string Bpcode { get; set; } = null!;

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public short ProjectId { get; set; }

    public string Remark { get; set; } = null!;

    public string PurchaserType { get; set; } = null!;

    public string PurchaserName { get; set; } = null!;

    public string PurchaserFatherName { get; set; } = null!;

    public string PurchaserCnic { get; set; } = null!;

    public string PurchaserCellNo { get; set; } = null!;

    public DateOnly PurchaserDob { get; set; }

    public string SellerType { get; set; } = null!;

    public string SellerName { get; set; } = null!;

    public string SellerFatherName { get; set; } = null!;

    public string SellerCnic { get; set; } = null!;

    public string SellerCellNo { get; set; } = null!;

    public DateOnly SellerDob { get; set; }

    public string SellerAddress { get; set; } = null!;

    public string PurchaserAddress { get; set; } = null!;

    public string PurchaserResidentStatus { get; set; } = null!;

    public string SellerResidentStatus { get; set; } = null!;

    public int Taxes { get; set; }

    public int TotalPrice { get; set; }

    public string Share { get; set; } = null!;

    public int TransferFee { get; set; }

    public string Uom { get; set; } = null!;

    public int ServiceCharges { get; set; }

    public string Strno { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public int? Tax236C { get; set; }

    public int? AdmittedTax { get; set; }

    public int? Tax236K { get; set; }

    public int? Pra { get; set; }

    public int? Gst { get; set; }

    public int? StampDuty { get; set; }

    public int? OtherTax { get; set; }

    public DateOnly? TokenDate { get; set; }

    public DateOnly? AdvanceDate { get; set; }

    public DateOnly? TransferDate { get; set; }

    public int? Price { get; set; }

    public string? FileNo { get; set; }

    public byte? CategoryId { get; set; }

    public string? TypeId { get; set; }

    public string? PropertyId { get; set; }

    public short? AreaId { get; set; }

    public string? ContractType { get; set; }

    public string? AllotmentLetterNo { get; set; }

    public string? MembershipNo { get; set; }

    public int? AmountBankA { get; set; }

    public string? BankAccountA { get; set; }

    public string? ChequeA { get; set; }

    public DateOnly? ChequeDateA { get; set; }

    public int? AmountBankB { get; set; }

    public string? BankAccountB { get; set; }

    public string? ChequeB { get; set; }

    public DateOnly? ChequeDateB { get; set; }

    public double? Years { get; set; }

    public int? RentPerMonth { get; set; }

    public double? PeriodOfTenancy { get; set; }

    public int? AdvanceAmount { get; set; }

    public int? RentSecurity { get; set; }

    public byte? SecurityMonth { get; set; }

    public DateOnly? EffectFrom { get; set; }

    public DateOnly? EffectTo { get; set; }

    public int? ElectricMeterReading { get; set; }

    public DateOnly? ElectricMeterReadingOn { get; set; }

    public int? GasMeterReading { get; set; }

    public DateOnly? GasMeterReadingOn { get; set; }

    public string? LandlordName { get; set; }

    public string? LandlordCnic { get; set; }

    public string? TenantName { get; set; }

    public string? TenantCnic { get; set; }

    public DateOnly? Cnicexpiry { get; set; }

    public int? BianaAmount { get; set; }

    public int? RemainingAmount { get; set; }

    public DateOnly? BianaValidity { get; set; }

    public string? Nocto { get; set; }

    public string? Subjects { get; set; }

    public string? NatureOfBusiness { get; set; }

    public string? PermanentAddress { get; set; }

    public short? NoOfEmployees { get; set; }

    public string? OwnerName { get; set; }

    public string? BusinessApprovalBy { get; set; }

    public string? DetailOfVehicles { get; set; }

    public double? AdvanceRentFor { get; set; }

    public string? Nationality { get; set; }

    public string? Passport { get; set; }

    public string? Occupation { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? City { get; set; }

    public byte? NoOfChildren { get; set; }

    public string? Members { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleRegNo { get; set; }

    public string? FamilyNo { get; set; }

    public string? PresentAddress { get; set; }

    public string? WorkAddress { get; set; }

    public string? AreaType { get; set; }

    public string? Road { get; set; }

    public string? District { get; set; }

    public string? Division { get; set; }

    public string? CompletePropertyAddress { get; set; }

    public string? SellerNationality { get; set; }

    public string? SellerPassport { get; set; }

    public string? Circle { get; set; }

    public string? PoliceStation { get; set; }

    public string? ServiceType { get; set; }

    public virtual BusinessPartnersMain BusinessPartnersMain { get; set; } = null!;

    public virtual ICollection<ContractPayment> ContractPayments { get; set; } = new List<ContractPayment>();

    public virtual SubSegment SubSegment { get; set; } = null!;

    public virtual User Suser { get; set; } = null!;
}
