using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLoanAndAdvance
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? Type { get; set; }

    public string? LoanAndAdvanceSerialNo { get; set; }

    public string? PaymentMode { get; set; }

    public string? AccountNumber { get; set; }

    public string? ChequeSlipNo { get; set; }

    public DateOnly? ChequeSlipDate { get; set; }

    public double? Amount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? LoanAndAdvanceTitle { get; set; }

    public string? AccountTitle { get; set; }

    public string? BankName { get; set; }

    public byte? BankId { get; set; }

    public string? EmployeeName { get; set; }

    public string? BranchCode { get; set; }
}
