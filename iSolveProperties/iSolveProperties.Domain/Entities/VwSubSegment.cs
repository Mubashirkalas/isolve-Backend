using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSubSegment
{
    public string? SegmentName { get; set; }

    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte? SegmentId { get; set; }

    public byte CompId { get; set; }

    public string? CaSubSegment { get; set; }

    public byte[]? SubSegmentPic { get; set; }

    public bool? CrprintWaterMark { get; set; }

    public string? GlDesc { get; set; }

    public bool? AllowBackDate { get; set; }

    public string? ContactPerson { get; set; }

    public DateOnly? BackDateTill { get; set; }

    public string? Prefix { get; set; }

    public byte? Prints { get; set; }

    public short? AllowLateDays { get; set; }

    public bool? Glrestriction { get; set; }

    public bool? GlvoucherApprovedWaterMark { get; set; }

    public bool? ClientOfficeCopyOnGlprint { get; set; }

    public string? WebLink { get; set; }
}
