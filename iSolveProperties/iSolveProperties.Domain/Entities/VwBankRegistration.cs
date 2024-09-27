using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankRegistration
{
    public int SubSegmentId { get; set; }

    public string? AccountTitle { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public DateOnly? AccountOpeningDate { get; set; }

    public string? ContactPerson { get; set; }

    public string? CellNo { get; set; }

    public string? BankName { get; set; }

    public DateOnly? Date { get; set; }

    public string? RegisterAddress { get; set; }

    public string? WhtName { get; set; }

    public string? BankChargesName { get; set; }

    public string? BankClearingName { get; set; }

    public string? CashAtBankName { get; set; }

    public byte? BankId { get; set; }

    public int? CompId { get; set; }

    public short? SNo { get; set; }

    public string? AccountNumber { get; set; }

    public string? CashAtBank { get; set; }

    public string? BankChargers { get; set; }

    public string? Wht { get; set; }

    public string? BankClearing { get; set; }

    public string? BankCharges { get; set; }

    public string? SubSegmentName { get; set; }
}
