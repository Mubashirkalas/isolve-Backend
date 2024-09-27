using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InvestorRegistration
{
    public byte CompId { get; set; }

    public int SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? ReturnType { get; set; }

    public string? ReturnValue { get; set; }

    public int? GraceDays { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? DealPurchaseSrno { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
