using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwConfirmationReceipt
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? ReceivedOn { get; set; }

    public string? Location { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BookingFormNo { get; set; }

    public string? ClientName { get; set; }

    public DateOnly? ReceiptDate { get; set; }

    public string? Remarks { get; set; }

    public string? MembershipNo { get; set; }

    public int? BookingFormSrno { get; set; }
}
