using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TradingReceiptsPayment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Type { get; set; }

    public string? TradingSrno { get; set; }

    public string? TradingSerialNo { get; set; }

    public string? TradingYear { get; set; }

    public string? PartyCode { get; set; }

    public int? TotalAmount { get; set; }

    public int? PreviousAmount { get; set; }

    public int? RemainingAmount { get; set; }

    public string? Remarks { get; set; }

    public int? Cash { get; set; }

    public int? BankChequePo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? AccountNo { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? Types { get; set; }

    public string? ReceivedFrom { get; set; }

    public string? ContactNo { get; set; }

    public string? AccountNoTwo { get; set; }

    public int? AmountTwo { get; set; }

    public string? ReferenceNoTwo { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
