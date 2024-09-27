using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCommissionReport
{
    public string? Bpname { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double? BookingPayable { get; set; }

    public double? ConfirmationPayable { get; set; }

    public double? Paid { get; set; }

    public decimal NetPayable { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? VNo { get; set; }

    public DateOnly? VDate { get; set; }
}
