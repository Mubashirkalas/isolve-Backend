using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCommissionPayment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Type { get; set; }

    public string? PaymentType { get; set; }

    public int? CashAmount { get; set; }

    public int? BankAmount { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }
}
