using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetReport
{
    public int SerialNo { get; set; }

    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public int? AmountPurchased { get; set; }

    public int? DepreciationPosted { get; set; }

    public int? SalesAmount { get; set; }

    public int? TypeId { get; set; }

    public byte CompId { get; set; }

    public string? AssetId { get; set; }

    public int Aamd { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }
}
