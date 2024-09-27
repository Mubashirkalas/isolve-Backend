using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CommissionPaymentBooking
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public int? BookingSrno { get; set; }

    public int? BookingCommissionDue { get; set; }

    public int? ConfirmationSrno { get; set; }

    public int? ConfirmationCommission { get; set; }

    public int? TotalCommissionDue { get; set; }

    public int? ComissionPaid { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual CommissionPayment? CommissionPayment { get; set; }
}
