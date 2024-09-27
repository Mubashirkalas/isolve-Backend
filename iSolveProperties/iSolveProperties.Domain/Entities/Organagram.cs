using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Organagram
{
    public string GlCode { get; set; } = null!;

    public string? GlDesc { get; set; }

    public double? GlAmountcr { get; set; }

    public double? GlAmountdr { get; set; }

    public string? GlPlcode { get; set; }

    public string? GlBlcode { get; set; }

    public string? GlCfcode { get; set; }

    public DateTime? GlDate { get; set; }

    public string? Uid { get; set; }

    public string? GlYear { get; set; }

    public byte CompId { get; set; }

    public int? GlUserId { get; set; }

    public string? GlWorkStation { get; set; }

    public string? GlPlcodeMgmt { get; set; }

    public string? GlBlcodeMgmt { get; set; }

    public string? GlCfcodeMgmt { get; set; }

    public bool? GlActivestatus { get; set; }

    public string? GlHidecode { get; set; }
}
