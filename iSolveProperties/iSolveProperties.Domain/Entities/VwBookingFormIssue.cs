using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormIssue
{
    public string SubSegmentName { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? Issue { get; set; }

    public string? AllocatedTo { get; set; }

    public string? IssueStatus { get; set; }

    public string? BookingFormNo { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectName { get; set; }
}
