using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FileDeliveryConfirmation
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

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

    public DateOnly? DeliveredDate { get; set; }

    public string? Remarks { get; set; }

    public string? DeliveredFromLocation { get; set; }

    public virtual BookingForm? BookingForm { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
