using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankclearingDetail
{
    public int? Vno { get; set; }

    public string? Vtype { get; set; }

    public string? Srno { get; set; }

    public DateOnly? Vdate { get; set; }

    public string? GlCode { get; set; }

    public string? Narration { get; set; }

    public string? ChequeSlipno { get; set; }

    public DateOnly? ChequeSlipdate { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public bool? Cleared { get; set; }

    public bool? Dishonoured { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public short? Sno { get; set; }

    public string? BankName { get; set; }

    public string? Vkey { get; set; }

    public short? VoucherSno { get; set; }

    public string? RecoveryAgent { get; set; }

    public string? RecoveryAgentName { get; set; }
}
