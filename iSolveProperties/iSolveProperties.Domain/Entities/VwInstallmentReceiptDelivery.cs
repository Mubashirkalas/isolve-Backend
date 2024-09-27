using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInstallmentReceiptDelivery
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientRepresentativeName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? BookingFormSrno { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? DeliveredDate { get; set; }

    public string? Remarks { get; set; }

    public string? DeliveredFromLocation { get; set; }

    public string? Expr1 { get; set; }

    public int? Expr2 { get; set; }
}
