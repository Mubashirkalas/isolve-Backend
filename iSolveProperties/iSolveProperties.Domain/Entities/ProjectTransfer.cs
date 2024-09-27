using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectTransfer
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public string? TransfererCode { get; set; }

    public string? TransfereeCode { get; set; }

    public double? TransferFee { get; set; }

    public string? CashBank { get; set; }

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

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? Cnic { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public byte[]? Pic { get; set; }

    public string? BioMetricId { get; set; }

    public int? FingerPrintSrno { get; set; }

    public string? TransfererBioMatricId { get; set; }

    public string? TransfererVerified { get; set; }

    public string? NextToKin { get; set; }

    public string? NextToKinContact { get; set; }

    public string? FatherName { get; set; }

    public string? Relationship { get; set; }

    public string? NextToKinAddress { get; set; }

    public string? NextToKinCnic { get; set; }

    public string? NextToKinFatherName { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMainNavigation { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual User? Muser { get; set; }

    public virtual ProjectSale? ProjectSale { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
