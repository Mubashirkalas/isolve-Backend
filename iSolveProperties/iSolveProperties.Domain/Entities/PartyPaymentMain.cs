using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyPaymentMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? AdvanceBal { get; set; }

    public double? InvoiceBal { get; set; }

    public double? SecurityBal { get; set; }

    public double? ApAccuralBal { get; set; }

    public double? NetBal { get; set; }

    public string? BpType { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string? AcNo { get; set; }

    public string? CheqSlipNo { get; set; }

    public DateOnly? CheqSlipDate { get; set; }

    public double? CheqAmount { get; set; }

    public bool? PaymentOnAccount { get; set; }

    public short? SaveUserid { get; set; }

    public string? SaveWorkstation { get; set; }

    public string? SaveUsername { get; set; }

    public DateTime? SaveCreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }
}
