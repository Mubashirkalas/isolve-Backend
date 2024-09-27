using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountPolicyRegistration
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? PolicyName { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Criteria { get; set; }

    public int? Frequency { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<DiscountPosting> DiscountPostings { get; set; } = new List<DiscountPosting>();
}
