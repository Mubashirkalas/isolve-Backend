using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountPosting
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? PolicySrno { get; set; }

    public string? RefNo { get; set; }

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

    public string? DiscountTypeCode { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual DiscountPolicyRegistration? DiscountPolicyRegistration { get; set; }
}
