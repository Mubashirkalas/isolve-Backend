using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGetConfirmationPayement
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public double? Payment { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ChequeNo { get; set; }

    public string? PaymentMode { get; set; }

    public string? Bank { get; set; }

    public string? CashBankOnline { get; set; }

    public string? BookingFormNo { get; set; }

    public string? Bpname { get; set; }

    public string? ClientName { get; set; }

    public string? AreaTitle { get; set; }

    public string? City { get; set; }

    public string? ProjectName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? PaymentDate { get; set; }

    public string? ConfirmationPayment { get; set; }

    public string? BookingFormSrno { get; set; }

    public string? VendorCode { get; set; }

    public double? Amount { get; set; }

    public string? ProjectId { get; set; }

    public string? DealPurchaseSrno { get; set; }

    public string? Instrument { get; set; }

    public string? SalesManCommission { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? DealerCommission { get; set; }

    public string? ConfirmationAgainst { get; set; }

    public int? Cheque { get; set; }

    public int? Online { get; set; }

    public int? InstrumentAmount { get; set; }
}
