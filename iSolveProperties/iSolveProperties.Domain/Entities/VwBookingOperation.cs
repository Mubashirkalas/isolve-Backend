using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingOperation
{
    public string AcknwReceiptStatus { get; set; } = null!;

    public DateOnly? AcknwReceiptReceivedDate { get; set; }

    public DateOnly? AcknwReceiptDate { get; set; }

    public DateOnly? AcknwReceiptDeliveryDate { get; set; }

    public string? AcknwReceiptDeliveryRemarks { get; set; }

    public string AllocReceiptStatus { get; set; } = null!;

    public DateOnly? AllocReceiptReceivedDate { get; set; }

    public DateOnly? AllocReceiptDate { get; set; }

    public DateOnly? AllocReceiptDeliveryDate { get; set; }

    public string? AllocReceiptDeliveryRemarks { get; set; }

    public string AllotLetterStatus { get; set; } = null!;

    public DateOnly? AllotLetterReceivedDate { get; set; }

    public DateOnly? AllotLetterDate { get; set; }

    public DateOnly? AllotLetterDeliveryDate { get; set; }

    public string? AllotLetterDeliveryRemarks { get; set; }

    public int BookingFormSrno { get; set; }

    public byte BookingFormCompId { get; set; }
}
