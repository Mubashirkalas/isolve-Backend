using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DealPurchaseModified
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public int? DpserialNo { get; set; }

    public string? Bpcode { get; set; }

    public double? Amount { get; set; }

    public double? PaidViaCash { get; set; }

    public string? AccountNo { get; set; }

    public double? PaidViaBank { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public short? Project { get; set; }

    public int? CurrentAmount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual DealPurchase? DealPurchase { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
