using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectTransfer
{
    public string? SubSegmentName { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public string? TransfererCode { get; set; }

    public string? TransfereeCode { get; set; }

    public double? TransferFee { get; set; }

    public string? BankId { get; set; }

    public byte[]? TransfererBiometric { get; set; }

    public byte[]? TransfereeBiometric { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? TransfererName { get; set; }

    public string? TransfereeName { get; set; }

    public string? CashBank { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public DateOnly? Date { get; set; }

    public string? PropertyTitle { get; set; }

    public string? ProjectName { get; set; }

    public string? TeamLeader { get; set; }

    public string? ProjectSaleNo { get; set; }

    public string? TypeTitle { get; set; }

    public string? PropertyDescription { get; set; }

    public string? TransferName1 { get; set; }

    public string? TransferName2 { get; set; }

    public string? BlockName { get; set; }

    public string? AreaTitle { get; set; }

    public string? Cnic { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public string? BankName { get; set; }

    public short? ProjectId { get; set; }

    public byte[]? Pic { get; set; }

    public string? BioMetricId { get; set; }

    public int? FingerPrintSrno { get; set; }

    public string? TransfererBioMatricId { get; set; }

    public string? TransfererVerified { get; set; }

    public string? NextToKin { get; set; }

    public string? MembershipNo { get; set; }

    public string? ProjectAddress { get; set; }

    public string? ClientName { get; set; }

    public string? FatherName { get; set; }

    public string? NextToKinContact { get; set; }

    public string? Relationship { get; set; }

    public string? NextToKinAddress { get; set; }

    public string? NextToKinCnic { get; set; }

    public string? TransfererFatherName { get; set; }

    public string? TransfererNextToKinCnic { get; set; }

    public string? TransfererCnic { get; set; }

    public string? TransfererContact { get; set; }

    public string? TransfererAddress { get; set; }

    public string? NextToKinFatherName { get; set; }

    public string? TransfereeAddress { get; set; }

    public byte[]? TransfererPic { get; set; }

    public string? Remarks { get; set; }

    public byte? Prints { get; set; }

    public string? CategoryTitle { get; set; }

    public string? ProjectStatus { get; set; }

    public string? Status { get; set; }
}
