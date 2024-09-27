using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwOnlineBooking
{
    public int SerialNo { get; set; }

    public string? Date { get; set; }

    public DateTime? OriginalDate { get; set; }

    public string? CustomerName { get; set; }

    public string? Project { get; set; }

    public string? BookingType { get; set; }

    public string? Size { get; set; }

    public string? BookingCategory { get; set; }

    public string? PropertyDetail { get; set; }

    public string? BlockName { get; set; }

    public string? Cnic { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public string? Remarks { get; set; }

    public string? Imgurl { get; set; }
}
