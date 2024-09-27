using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class OpenTrading
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? City { get; set; }

    public string? Bpcode { get; set; }

    public double? Cash { get; set; }

    public double? Bank { get; set; }

    public int BankId { get; set; }

    public string? AccountNo { get; set; }

    public double? Total { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ReferingPersonCode { get; set; }

    public double? Commision { get; set; }

    public short? ProjectId { get; set; }

    public string? SalesPersonTwo { get; set; }

    public string? SalesPersonThree { get; set; }

    public int? SalesPersonTwoCommission { get; set; }

    public int? SalesPersonThreeCommission { get; set; }

    public string? Remarks { get; set; }

    public string? Type { get; set; }

    public string? PurchaserType { get; set; }

    public string? PurchaserName { get; set; }

    public string? PurchaserFatherName { get; set; }

    public string? PurchaserCnic { get; set; }

    public string? PurchaserCellNo { get; set; }

    public DateOnly? PurchaserDob { get; set; }

    public string? SellerType { get; set; }

    public string? SellerName { get; set; }

    public string? SellerFatherName { get; set; }

    public string? SellerCnic { get; set; }

    public string? SellerCellNo { get; set; }

    public DateOnly? SellerDob { get; set; }

    public string? SellerAddress { get; set; }

    public string? PurchaserAddress { get; set; }

    public string? PurchaserResidentStatus { get; set; }

    public string? SellerResidentStatus { get; set; }

    public string? Types { get; set; }

    public string? Otsrno { get; set; }

    public string? ContractFy { get; set; }

    public int? Taxes { get; set; }

    public int? TotalPrice { get; set; }

    public string? Share { get; set; }

    public int? TransferFee { get; set; }

    public string? Uom { get; set; }

    public int? ServiceCharges { get; set; }

    public string? Strno { get; set; }

    public string? PaymentMode { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain1 { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMainNavigation { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
