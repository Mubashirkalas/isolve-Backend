using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SocietyInstallment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public byte SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public int BookingFormSrno { get; set; }

    public double Payment { get; set; }

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ChequeNo { get; set; }

    public string? PaymentMode { get; set; }

    public string? Bank { get; set; }

    public string? CashBankOnline { get; set; }

    public string? DealPurchaseSrno { get; set; }

    public string? Instrument { get; set; }

    public string? SalesManCommission { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? DealerCommission { get; set; }

    public string? ConfirmationAgainst { get; set; }

    public int? Cheque { get; set; }

    public int? Online { get; set; }

    public int? InstrumentAmount { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public virtual BookingForm BookingForm { get; set; } = null!;
}
