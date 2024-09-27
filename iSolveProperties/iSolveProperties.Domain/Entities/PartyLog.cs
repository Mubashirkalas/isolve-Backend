using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyLog
{
    public string PrtyCode { get; set; } = null!;

    public int LogSerial { get; set; }

    public string? PrtyName { get; set; }

    public string? PrtyAdl1 { get; set; }

    public string? PrtyAdl2 { get; set; }

    public string? PrtyAdl3 { get; set; }

    public string? PrtyPhone { get; set; }

    public string? PrtyTlx { get; set; }

    public string? PrtyDesc { get; set; }

    public string? Glcode { get; set; }

    public string Year { get; set; } = null!;

    public decimal? PrtyOpbalance { get; set; }

    public DateTime? OpDate { get; set; }

    public string? SUser { get; set; }

    public int CompId { get; set; }

    public int? PrtyUserid { get; set; }

    public string? PrtyWorkstation { get; set; }

    public DateTime? PrtyDateModified { get; set; }

    public string? PrtyActionTaken { get; set; }
}
