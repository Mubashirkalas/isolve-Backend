using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInstallmentReceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? ReceivedOn { get; set; }

    public string? Location { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BookingFormNo { get; set; }

    public string? ClientName { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public int? BookingFormSrno { get; set; }
}
