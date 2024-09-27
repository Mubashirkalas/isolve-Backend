using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMappingLeadsVsBooking
{
    public string? Bpname { get; set; }

    public string? EmployeeName { get; set; }

    public string? UserName { get; set; }

    public string? Booking { get; set; }

    public string? Leads { get; set; }

    public DateTime? Date { get; set; }

    public string? BookingFormNo { get; set; }

    public string SerialNo { get; set; } = null!;
}
