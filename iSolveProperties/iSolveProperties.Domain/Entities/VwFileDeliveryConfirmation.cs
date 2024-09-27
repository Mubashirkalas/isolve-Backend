using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFileDeliveryConfirmation
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? BookingFormSrno { get; set; }

    public string? FileNo { get; set; }

    public string? Dealer { get; set; }

    public string? ReceiverName { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Bpname { get; set; }

    public DateOnly? DeliveredDate { get; set; }

    public string? Remarks { get; set; }

    public string? DeliveredFromLocation { get; set; }
}
