using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Depreciation
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? TypeId { get; set; }

    public byte? TimePeriod { get; set; }

    public short? SubSegmentId { get; set; }

    public int? SerialNo { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual AssetType? AssetType { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual SubSegment? SubSegment { get; set; }
}
