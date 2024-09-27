using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwReceiptsDelivery
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientRepresentativeName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? ReceiptNo { get; set; }

    public DateOnly? DeliveredDate { get; set; }

    public string? Remarks { get; set; }

    public string? DeliveredFromLocation { get; set; }

    public string? BookingFormNo { get; set; }

    public int? BookingFormSrno { get; set; }
}
