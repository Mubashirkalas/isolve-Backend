using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSocietyInstallment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public byte SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public double Payment { get; set; }

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ChequeNo { get; set; }

    public string? PaymentMode { get; set; }

    public string? Bank { get; set; }

    public string? CashBankOnline { get; set; }

    public string? BankName { get; set; }

    public int BookingFormSrno { get; set; }

    public string? DealPurchaseSrno { get; set; }

    public string? Instrument { get; set; }

    public string? DealName { get; set; }

    public string? BookingFormNo { get; set; }

    public double? TotalAmount { get; set; }

    public string? Bpname { get; set; }

    public string? DealerOldCommission { get; set; }

    public string? DealerCode { get; set; }

    public string? Dealer { get; set; }

    public string? ReferringPersonOldCommission { get; set; }

    public string? TeamLeader { get; set; }

    public string? TeamLeaderOldCommission { get; set; }

    public string? TeamLeaderName { get; set; }

    public int? SocietySerialNo { get; set; }

    public string? PlanName { get; set; }

    public string? ReferringPerson { get; set; }

    public string? DealerCommission { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? SalesManCommission { get; set; }

    public string? CsalesManCommission { get; set; }

    public string? CteamLeaderCommission { get; set; }

    public string? CdealerCommission { get; set; }

    public string? ConfirmationAgainst { get; set; }

    public int? Cheque { get; set; }

    public int? Online { get; set; }

    public int? InstrumentAmount { get; set; }

    public string? ClientName { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
