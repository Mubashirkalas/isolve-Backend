using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class QuotaAllocationModified
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public int? DpserialNo { get; set; }

    public int? QuotaSerialNo { get; set; }

    public int? QuotaSrno { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
