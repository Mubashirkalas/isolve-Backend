using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Igpmaster1
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public int SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public string Keys { get; set; } = null!;

    public string? Status { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? Pono { get; set; }

    public DateOnly? Podate { get; set; }

    public string? VehicleNo { get; set; }

    public string? BuiltyNo { get; set; }

    public string? DriverName { get; set; }

    public string? DriverCellNo { get; set; }

    public string? Bpcode { get; set; }

    public string? CarriageType { get; set; }

    public string? Pokey { get; set; }

    public string? Bpname { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
