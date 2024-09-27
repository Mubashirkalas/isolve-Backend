using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CommissionPayment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Type { get; set; }

    public string? PaymentType { get; set; }

    public int? CashAmount { get; set; }

    public int? BankAmount { get; set; }

    public string? AccountNo { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
