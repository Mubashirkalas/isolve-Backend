using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class StockIssue
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public short? WarehouseNo { get; set; }

    public short? SubProjectId { get; set; }

    public string? Keys { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
