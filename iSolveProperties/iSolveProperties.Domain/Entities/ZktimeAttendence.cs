using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ZktimeAttendence
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime AttDate { get; set; }

    public int? Timetable { get; set; }

    public DateTime? Checkin { get; set; }

    public DateTime? Checkout { get; set; }

    public DateTime? Roundin { get; set; }

    public DateTime? Roundout { get; set; }

    public int? WorkedMinutes { get; set; }

    public int? RworkedMinutes { get; set; }

    public int? BreakMinutes { get; set; }

    public string? Remark { get; set; }

    public int? Wc { get; set; }
}
