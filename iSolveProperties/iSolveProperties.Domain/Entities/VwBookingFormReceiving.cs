using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormReceiving
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? ReceivedOn { get; set; }

    public string? SubSegmentName { get; set; }

    public int? BookingFormSrno { get; set; }

    public short? UserId { get; set; }

    public string? UserName { get; set; }

    public string? BookingFormNo { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectName { get; set; }

    public string? PropertyTitle { get; set; }

    public string? AreaTitle { get; set; }

    public string? CategoryTitle { get; set; }

    public string? TypeTitle { get; set; }

    public short? SubSegmentFrom { get; set; }

    public short? SubSegmentTo { get; set; }

    public string? SubSegmentFromName { get; set; }

    public string? SubSegmentToName { get; set; }
}
