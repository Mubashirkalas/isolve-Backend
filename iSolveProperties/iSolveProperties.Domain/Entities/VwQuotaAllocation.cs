using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotaAllocation
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public int? DpserialNo { get; set; }

    public double? Amount { get; set; }

    public double? PaidViaCash { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }

    public double? PaidViaBank { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public short? Project { get; set; }

    public string? ProjectName { get; set; }

    public string? Bpname { get; set; }

    public string? Bpcode { get; set; }

    public string? DealName { get; set; }
}
