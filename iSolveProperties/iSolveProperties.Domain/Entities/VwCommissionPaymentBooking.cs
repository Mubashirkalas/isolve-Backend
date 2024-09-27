using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCommissionPaymentBooking
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public int? BookingSrno { get; set; }

    public string? BookingFormNo { get; set; }

    public int? BookingCommissionDue { get; set; }

    public int? ConfirmationSrno { get; set; }

    public int? ConfirmationCommission { get; set; }

    public int? TotalCommissionDue { get; set; }

    public int? ComissionPaid { get; set; }
}
