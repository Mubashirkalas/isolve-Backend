using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwChequesClearingMainDetail
{
    public int? Sno { get; set; }

    public string? PaymentSrno { get; set; }

    public string? ChequesSrno { get; set; }

    public string? Bpcode { get; set; }

    public byte? BankId { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? Amount { get; set; }

    public bool? Cleared { get; set; }

    public bool? Dishonoured { get; set; }

    public string? BankName { get; set; }

    public string? Bpname { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
