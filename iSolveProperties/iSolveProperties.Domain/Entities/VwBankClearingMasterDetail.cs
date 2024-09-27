using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankClearingMasterDetail
{
    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? AcNo { get; set; }

    public byte CompId { get; set; }

    public string Fyear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public double? Wht { get; set; }

    public double? BankCharges { get; set; }

    public string? VKey { get; set; }

    public short? SaveUserId { get; set; }

    public string? SaveWorkStation { get; set; }

    public string? SaveUserName { get; set; }

    public DateTime? SaveCreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUserName { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public double? Balance { get; set; }

    public string? Type { get; set; }

    public string? AccountTitle { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public byte BankId { get; set; }

    public string? BankName { get; set; }

    public int? Vno { get; set; }

    public DateOnly? Vdate { get; set; }

    public string? Vtype { get; set; }

    public string? ChequeSlipNo { get; set; }

    public DateOnly? ChequeSlipDate { get; set; }

    public string? GlCode { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public bool? Cleared { get; set; }

    public bool? Dishonoured { get; set; }

    public short? VoucherSno { get; set; }

    public string? RecoveryAgent { get; set; }

    public string? RecoveryAgentName { get; set; }
}
