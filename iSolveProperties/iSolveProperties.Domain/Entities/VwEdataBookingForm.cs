using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEdataBookingForm
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? BookingFormNo { get; set; }

    public string? FileName { get; set; }

    public string? FileData { get; set; }

    public string? FileType { get; set; }

    public string? Type { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? TransactionForm { get; set; }

    public string? TransactionFormNo { get; set; }

    public string? SubSegmentNames { get; set; }
}
