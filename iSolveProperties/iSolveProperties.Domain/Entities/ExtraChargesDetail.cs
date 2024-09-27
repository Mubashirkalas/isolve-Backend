using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ExtraChargesDetail
{
    public byte SerialNo { get; set; }

    public int CompId { get; set; }

    public string? ExtraChargesTitle { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }
}
