using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPlotAllocationReceiptDelivery
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? ReceiptSrno { get; set; }

    public int? ReceiptSerialNo { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? ReceivedBy { get; set; }

    public string? Courier { get; set; }

    public string? DeliveredFrom { get; set; }

    public string? Remarks { get; set; }
}
