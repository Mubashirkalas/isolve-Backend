using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInvestorDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? AmountInCash { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? PartyCode { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public int? GraceDays { get; set; }

    public string? InvestmentType { get; set; }

    public int? AmountInBank { get; set; }

    public string? AccountNo { get; set; }

    public string? SecurityChequeNo { get; set; }

    public string? CustomerBankAccountNo { get; set; }

    public string? BankName { get; set; }

    public string? ReferredCode { get; set; }

    public string? SecurityChequeBankName { get; set; }

    public string? SecurityChequeBank { get; set; }

    public string? PartyName { get; set; }

    public string? ReferredBy { get; set; }

    public string? FileName { get; set; }

    public string? FileData { get; set; }

    public string? FileType { get; set; }
}
