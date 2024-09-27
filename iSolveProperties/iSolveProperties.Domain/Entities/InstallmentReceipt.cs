﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InstallmentReceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? ReceivedOn { get; set; }

    public string? Location { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? MembershipNo { get; set; }

    public virtual BookingForm? BookingForm { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
