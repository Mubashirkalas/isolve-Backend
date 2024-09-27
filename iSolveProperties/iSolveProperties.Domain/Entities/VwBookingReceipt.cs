using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingReceipt
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

    public string? ConfirmationReceipt { get; set; }

    public string? BookingReceiptsDelivery { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? MembershipNo { get; set; }

    public short? SubSegmentFrom { get; set; }

    public short? SubSegmentTo { get; set; }

    public string? SubSegmentFromName { get; set; }

    public string? SubSegmentToName { get; set; }
}
