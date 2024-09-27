using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class StockAdustmentMaster
{
    public string Srno { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SUser { get; set; }

    public short? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public short? SubSegmentId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }
}
